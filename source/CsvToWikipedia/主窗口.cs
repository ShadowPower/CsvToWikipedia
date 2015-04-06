using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CsvToWikipedia
{
    public partial class 主窗口 : Form
    {
        string inputText;
        int row = 0, col = 0; //行数，列数

        public 主窗口()
        {
            InitializeComponent();
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Csv表格 (*.csv)|*.csv";
                fd.Title = "打开";
                fd.RestoreDirectory = true;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(fd.FileName, System.Text.Encoding.Default);
                    inputText = reader.ReadToEnd();
                    reader.Close();

                    //计算行数列数
                    row = inputText.Split('\n').Length - 1;//末尾有一空行
                    col = inputText.Split('\n')[0].Split(',').Length;
                }
                else
                {
                    MessageBox.Show("未打开任何文件", "提示");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("无法打开文件\n可能是文件格式错误或文件被占用");
            }
        }

        private string generate()
        {
            StringBuilder outputText = new StringBuilder();

            string[] lines = inputText.Split('\n'); //单独存放每行
            string[] cell; //单独存放每个格子
            int initialRow = 0; //起始行号

            outputText.Append("{| class=\"wikitable");
            if (checkBox_Sort.Checked)
                outputText.Append(" sortable");
            if (radioButton_Fold.Checked)
                outputText.Append(" mw-collapsible");
            if (radioButton_Folded.Checked)
                outputText.Append(" mw-collapsible mw-collapsed");
            outputText.Append("\"" + System.Environment.NewLine);

            cell = lines[0].Split(',');

            if (checkBox_Title.Checked)
            {
                outputText.Append("|+ " + cell[0] + System.Environment.NewLine);
                initialRow++;
            }

            try
            {
                cell = lines[initialRow].Split(',');
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("表格大小与设置的情况不符，请检查左侧设置项", "错误");
                return "";
            }

            if (checkBox_Col.Checked)
            {
                for (int i = 0; i < cell.Length; i++)
                {
                    if (i == 0)
                    {
                        outputText.Append("! " + cell[i]);
                    }
                    else
                    {
                        outputText.Append(" !! " + cell[i]);
                    }
                }
                outputText.Append(System.Environment.NewLine);
                initialRow++;
            }

            for (int i = initialRow; i < row; i++)
            {
                outputText.Append("|-" + System.Environment.NewLine);
                cell = lines[i].Split(',');
                for (int j = 0; j < col; j++)
                {
                    if (j == 0)
                        if (checkBox_Row.Checked)
                            outputText.Append("! scope=\"row\" | " + cell[j] + System.Environment.NewLine);
                        else
                            outputText.Append("| " + cell[j]);
                    else
                        if (checkBox_Row.Checked && j == 1)
                            outputText.Append("| " + cell[j]);
                        else
                            outputText.Append(" || " + cell[j]);
                }
                outputText.Append(System.Environment.NewLine);
            }
            outputText.Append("|}" + System.Environment.NewLine);
            return outputText.ToString();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            string output = generate();

            //如果生成失败，返回
            if (output == "")
                return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件 (*.txt)|*.txt";
            sfd.Title = "保存";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.Default);
                    sw.Flush();
                    sw.Write(output);
                    sw.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("写出文件失败", "错误");
                }
            }
        }

        private void button_Clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(generate());
        }
    }
}
