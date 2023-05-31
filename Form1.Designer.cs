namespace FileNameChange
{
    partial class RegexExpressTextBox
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
            this.FileReadBnt = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.RegexExpressLabel = new System.Windows.Forms.Label();
            this.FilePathUpdateBnt = new System.Windows.Forms.Button();
            this.regexInputTextBox = new System.Windows.Forms.TextBox();
            this.FileUpdateResultBnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileReadBnt
            // 
            this.FileReadBnt.Location = new System.Drawing.Point(61, 25);
            this.FileReadBnt.Name = "FileReadBnt";
            this.FileReadBnt.Size = new System.Drawing.Size(75, 23);
            this.FileReadBnt.TabIndex = 0;
            this.FileReadBnt.Text = "檔案讀取";
            this.FileReadBnt.UseVisualStyleBackColor = true;
            this.FileReadBnt.Click += new System.EventHandler(this.FileReadBnt_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(156, 26);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(557, 22);
            this.FilePathTextBox.TabIndex = 1;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.FilePathTextBox_TextChanged);
            // 
            // RegexExpressLabel
            // 
            this.RegexExpressLabel.AutoSize = true;
            this.RegexExpressLabel.Font = new System.Drawing.Font("新細明體", 10F);
            this.RegexExpressLabel.Location = new System.Drawing.Point(59, 93);
            this.RegexExpressLabel.Name = "RegexExpressLabel";
            this.RegexExpressLabel.Size = new System.Drawing.Size(77, 14);
            this.RegexExpressLabel.TabIndex = 2;
            this.RegexExpressLabel.Text = "正規表達式";
            // 
            // FilePathUpdateBnt
            // 
            this.FilePathUpdateBnt.Location = new System.Drawing.Point(73, 218);
            this.FilePathUpdateBnt.Name = "FilePathUpdateBnt";
            this.FilePathUpdateBnt.Size = new System.Drawing.Size(252, 121);
            this.FilePathUpdateBnt.TabIndex = 4;
            this.FilePathUpdateBnt.Text = "檔案路徑更新";
            this.FilePathUpdateBnt.UseVisualStyleBackColor = true;
            this.FilePathUpdateBnt.Click += new System.EventHandler(this.FilePathUpdateBnt_Click);
            // 
            // regexInputTextBox
            // 
            this.regexInputTextBox.Location = new System.Drawing.Point(156, 93);
            this.regexInputTextBox.Name = "regexInputTextBox";
            this.regexInputTextBox.Size = new System.Drawing.Size(557, 22);
            this.regexInputTextBox.TabIndex = 5;
            this.regexInputTextBox.Text = "^(?<filePath>.*?)(?=\\.\\[545BC58F\\[decryptfile@onionmail\\.org\\]\\.)";
            // 
            // FileUpdateResultBnt
            // 
            this.FileUpdateResultBnt.Location = new System.Drawing.Point(452, 218);
            this.FileUpdateResultBnt.Name = "FileUpdateResultBnt";
            this.FileUpdateResultBnt.Size = new System.Drawing.Size(261, 121);
            this.FileUpdateResultBnt.TabIndex = 6;
            this.FileUpdateResultBnt.Text = "路徑更新結果清單";
            this.FileUpdateResultBnt.UseVisualStyleBackColor = true;
            this.FileUpdateResultBnt.Click += new System.EventHandler(this.FileUpdateResultBnt_Click);
            // 
            // RegexExpressTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileUpdateResultBnt);
            this.Controls.Add(this.regexInputTextBox);
            this.Controls.Add(this.FilePathUpdateBnt);
            this.Controls.Add(this.RegexExpressLabel);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FileReadBnt);
            this.Name = "RegexExpressTextBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileReadBnt;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Label RegexExpressLabel;
        private System.Windows.Forms.Button FilePathUpdateBnt;
        private System.Windows.Forms.TextBox regexInputTextBox;
        private System.Windows.Forms.Button FileUpdateResultBnt;
    }
}

