namespace CsvToWikipedia
{
    partial class 主窗口
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.groupBox_header = new System.Windows.Forms.GroupBox();
            this.checkBox_Col = new System.Windows.Forms.CheckBox();
            this.checkBox_Row = new System.Windows.Forms.CheckBox();
            this.checkBox_Title = new System.Windows.Forms.CheckBox();
            this.checkBox_Sort = new System.Windows.Forms.CheckBox();
            this.radioButton_NoFold = new System.Windows.Forms.RadioButton();
            this.radioButton_Fold = new System.Windows.Forms.RadioButton();
            this.radioButton_Folded = new System.Windows.Forms.RadioButton();
            this.button_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Clipboard = new System.Windows.Forms.Button();
            this.groupBox_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(240, 13);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.button_OpenFile.TabIndex = 2;
            this.button_OpenFile.Text = "打开文件";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // groupBox_header
            // 
            this.groupBox_header.Controls.Add(this.checkBox_Col);
            this.groupBox_header.Controls.Add(this.checkBox_Row);
            this.groupBox_header.Location = new System.Drawing.Point(13, 42);
            this.groupBox_header.Name = "groupBox_header";
            this.groupBox_header.Size = new System.Drawing.Size(126, 95);
            this.groupBox_header.TabIndex = 1;
            this.groupBox_header.TabStop = false;
            this.groupBox_header.Text = "表头";
            // 
            // checkBox_Col
            // 
            this.checkBox_Col.AutoSize = true;
            this.checkBox_Col.Location = new System.Drawing.Point(49, 20);
            this.checkBox_Col.Name = "checkBox_Col";
            this.checkBox_Col.Size = new System.Drawing.Size(72, 16);
            this.checkBox_Col.TabIndex = 0;
            this.checkBox_Col.Text = "列 = = =";
            this.checkBox_Col.UseVisualStyleBackColor = true;
            // 
            // checkBox_Row
            // 
            this.checkBox_Row.AutoSize = true;
            this.checkBox_Row.Location = new System.Drawing.Point(7, 34);
            this.checkBox_Row.Name = "checkBox_Row";
            this.checkBox_Row.Size = new System.Drawing.Size(36, 52);
            this.checkBox_Row.TabIndex = 1;
            this.checkBox_Row.Text = "行\r\n=\r\n=\r\n=";
            this.checkBox_Row.UseVisualStyleBackColor = true;
            // 
            // checkBox_Title
            // 
            this.checkBox_Title.AutoSize = true;
            this.checkBox_Title.Location = new System.Drawing.Point(12, 16);
            this.checkBox_Title.Name = "checkBox_Title";
            this.checkBox_Title.Size = new System.Drawing.Size(96, 16);
            this.checkBox_Title.TabIndex = 0;
            this.checkBox_Title.Text = "第一行为标题";
            this.checkBox_Title.UseVisualStyleBackColor = true;
            // 
            // checkBox_Sort
            // 
            this.checkBox_Sort.AutoSize = true;
            this.checkBox_Sort.Location = new System.Drawing.Point(157, 51);
            this.checkBox_Sort.Name = "checkBox_Sort";
            this.checkBox_Sort.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Sort.TabIndex = 3;
            this.checkBox_Sort.Text = "排序";
            this.checkBox_Sort.UseVisualStyleBackColor = true;
            // 
            // radioButton_NoFold
            // 
            this.radioButton_NoFold.AutoSize = true;
            this.radioButton_NoFold.Checked = true;
            this.radioButton_NoFold.Location = new System.Drawing.Point(157, 73);
            this.radioButton_NoFold.Name = "radioButton_NoFold";
            this.radioButton_NoFold.Size = new System.Drawing.Size(59, 16);
            this.radioButton_NoFold.TabIndex = 4;
            this.radioButton_NoFold.TabStop = true;
            this.radioButton_NoFold.Text = "无折叠";
            this.radioButton_NoFold.UseVisualStyleBackColor = true;
            // 
            // radioButton_Fold
            // 
            this.radioButton_Fold.AutoSize = true;
            this.radioButton_Fold.Location = new System.Drawing.Point(157, 96);
            this.radioButton_Fold.Name = "radioButton_Fold";
            this.radioButton_Fold.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Fold.TabIndex = 5;
            this.radioButton_Fold.Text = "折叠";
            this.radioButton_Fold.UseVisualStyleBackColor = true;
            // 
            // radioButton_Folded
            // 
            this.radioButton_Folded.AutoSize = true;
            this.radioButton_Folded.Location = new System.Drawing.Point(157, 119);
            this.radioButton_Folded.Name = "radioButton_Folded";
            this.radioButton_Folded.Size = new System.Drawing.Size(59, 16);
            this.radioButton_Folded.TabIndex = 6;
            this.radioButton_Folded.Text = "已折叠";
            this.radioButton_Folded.UseVisualStyleBackColor = true;
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(240, 42);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 23);
            this.button_Generate.TabIndex = 7;
            this.button_Generate.Text = "生成表格";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "作者：暗影夜光";
            // 
            // button_Clipboard
            // 
            this.button_Clipboard.Location = new System.Drawing.Point(240, 71);
            this.button_Clipboard.Name = "button_Clipboard";
            this.button_Clipboard.Size = new System.Drawing.Size(75, 23);
            this.button_Clipboard.TabIndex = 9;
            this.button_Clipboard.Text = "写入剪贴板";
            this.button_Clipboard.UseVisualStyleBackColor = true;
            this.button_Clipboard.Click += new System.EventHandler(this.button_Clipboard_Click);
            // 
            // 主窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 152);
            this.Controls.Add(this.button_Clipboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.radioButton_Folded);
            this.Controls.Add(this.radioButton_Fold);
            this.Controls.Add(this.radioButton_NoFold);
            this.Controls.Add(this.checkBox_Sort);
            this.Controls.Add(this.checkBox_Title);
            this.Controls.Add(this.groupBox_header);
            this.Controls.Add(this.button_OpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "主窗口";
            this.Text = "Csv转维基百科表格";
            this.groupBox_header.ResumeLayout(false);
            this.groupBox_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.GroupBox groupBox_header;
        private System.Windows.Forms.CheckBox checkBox_Col;
        private System.Windows.Forms.CheckBox checkBox_Row;
        private System.Windows.Forms.CheckBox checkBox_Title;
        private System.Windows.Forms.CheckBox checkBox_Sort;
        private System.Windows.Forms.RadioButton radioButton_NoFold;
        private System.Windows.Forms.RadioButton radioButton_Fold;
        private System.Windows.Forms.RadioButton radioButton_Folded;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Clipboard;
    }
}

