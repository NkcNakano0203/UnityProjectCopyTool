namespace UnityProjectCopyTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.IncludePackagesCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.AlwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFolderDialogButton = new System.Windows.Forms.Button();
            this.SelectFolderAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IncludePackagesCheckBox
            // 
            this.IncludePackagesCheckBox.AutoSize = true;
            this.IncludePackagesCheckBox.Location = new System.Drawing.Point(14, 138);
            this.IncludePackagesCheckBox.Name = "IncludePackagesCheckBox";
            this.IncludePackagesCheckBox.Size = new System.Drawing.Size(113, 16);
            this.IncludePackagesCheckBox.TabIndex = 0;
            this.IncludePackagesCheckBox.Text = "Packagesを含める";
            this.IncludePackagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(331, 151);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(107, 32);
            this.CopyButton.TabIndex = 1;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // AlwaysOnTopCheckBox
            // 
            this.AlwaysOnTopCheckBox.AutoSize = true;
            this.AlwaysOnTopCheckBox.Location = new System.Drawing.Point(14, 160);
            this.AlwaysOnTopCheckBox.Name = "AlwaysOnTopCheckBox";
            this.AlwaysOnTopCheckBox.Size = new System.Drawing.Size(157, 16);
            this.AlwaysOnTopCheckBox.TabIndex = 2;
            this.AlwaysOnTopCheckBox.Text = "ウィンドウを常に最前面表示";
            this.AlwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            this.AlwaysOnTopCheckBox.CheckedChanged += new System.EventHandler(this.AlwaysOnTopCheckBox_CheckedChanged);
            this.AlwaysOnTopCheckBox.Click += new System.EventHandler(this.AlwaysOnTopCheckBox_CheckedChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // OpenFolderDialogButton
            // 
            this.OpenFolderDialogButton.Location = new System.Drawing.Point(331, 64);
            this.OpenFolderDialogButton.Name = "OpenFolderDialogButton";
            this.OpenFolderDialogButton.Size = new System.Drawing.Size(31, 19);
            this.OpenFolderDialogButton.TabIndex = 3;
            this.OpenFolderDialogButton.Text = "・・・";
            this.OpenFolderDialogButton.UseVisualStyleBackColor = true;
            this.OpenFolderDialogButton.Click += new System.EventHandler(this.OpenFolderDialogButton_Click);
            // 
            // SelectFolderAddressTextBox
            // 
            this.SelectFolderAddressTextBox.Location = new System.Drawing.Point(119, 64);
            this.SelectFolderAddressTextBox.Name = "SelectFolderAddressTextBox";
            this.SelectFolderAddressTextBox.ReadOnly = true;
            this.SelectFolderAddressTextBox.Size = new System.Drawing.Size(206, 19);
            this.SelectFolderAddressTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 195);
            this.Controls.Add(this.SelectFolderAddressTextBox);
            this.Controls.Add(this.OpenFolderDialogButton);
            this.Controls.Add(this.AlwaysOnTopCheckBox);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.IncludePackagesCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IncludePackagesCheckBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.CheckBox AlwaysOnTopCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button OpenFolderDialogButton;
        private System.Windows.Forms.TextBox SelectFolderAddressTextBox;
    }
}

