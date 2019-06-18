namespace FileCopy
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.textBoxCopyPath = new System.Windows.Forms.TextBox();
            this.buttonCopyTo = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonFileFrom = new System.Windows.Forms.Button();
            this.textBoxFileFrom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(93, 22);
            this.buttonSelectFile.TabIndex = 3;
            this.buttonSelectFile.Text = "選擇檔案";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 12;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 40);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(472, 376);
            this.listBoxFiles.TabIndex = 4;
            // 
            // textBoxCopyPath
            // 
            this.textBoxCopyPath.Location = new System.Drawing.Point(92, 454);
            this.textBoxCopyPath.Name = "textBoxCopyPath";
            this.textBoxCopyPath.Size = new System.Drawing.Size(391, 22);
            this.textBoxCopyPath.TabIndex = 5;
            // 
            // buttonCopyTo
            // 
            this.buttonCopyTo.Location = new System.Drawing.Point(12, 452);
            this.buttonCopyTo.Name = "buttonCopyTo";
            this.buttonCopyTo.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyTo.TabIndex = 6;
            this.buttonCopyTo.Text = "複製到...";
            this.buttonCopyTo.UseVisualStyleBackColor = true;
            this.buttonCopyTo.Click += new System.EventHandler(this.ButtonCopyTo_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(12, 482);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(471, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "複製";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // buttonFileFrom
            // 
            this.buttonFileFrom.Location = new System.Drawing.Point(13, 423);
            this.buttonFileFrom.Name = "buttonFileFrom";
            this.buttonFileFrom.Size = new System.Drawing.Size(74, 23);
            this.buttonFileFrom.TabIndex = 8;
            this.buttonFileFrom.Text = "檔案來自";
            this.buttonFileFrom.UseVisualStyleBackColor = true;
            this.buttonFileFrom.Click += new System.EventHandler(this.ButtonFileFrom_Click);
            // 
            // textBoxFileFrom
            // 
            this.textBoxFileFrom.Location = new System.Drawing.Point(93, 423);
            this.textBoxFileFrom.Name = "textBoxFileFrom";
            this.textBoxFileFrom.Size = new System.Drawing.Size(390, 22);
            this.textBoxFileFrom.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 516);
            this.Controls.Add(this.textBoxFileFrom);
            this.Controls.Add(this.buttonFileFrom);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonCopyTo);
            this.Controls.Add(this.textBoxCopyPath);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.buttonSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox textBoxCopyPath;
        private System.Windows.Forms.Button buttonCopyTo;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonFileFrom;
        private System.Windows.Forms.TextBox textBoxFileFrom;
    }
}

