namespace ModUpdater
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backupDirTextBox = new System.Windows.Forms.TextBox();
            this.backupDirLabel = new System.Windows.Forms.Label();
            this.enableBackupCheckBox = new System.Windows.Forms.CheckBox();
            this.enableBackupLabel = new System.Windows.Forms.Label();
            this.updateCheckTimeTextBox = new System.Windows.Forms.TextBox();
            this.updateCheckTimeLabel = new System.Windows.Forms.Label();
            this.enableUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.enableUpdateLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.comfirmButton = new System.Windows.Forms.Button();
            this.errorMessegeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorMessegeLabel);
            this.groupBox1.Controls.Add(this.backupDirTextBox);
            this.groupBox1.Controls.Add(this.backupDirLabel);
            this.groupBox1.Controls.Add(this.enableBackupCheckBox);
            this.groupBox1.Controls.Add(this.enableBackupLabel);
            this.groupBox1.Controls.Add(this.updateCheckTimeTextBox);
            this.groupBox1.Controls.Add(this.updateCheckTimeLabel);
            this.groupBox1.Controls.Add(this.enableUpdateCheckBox);
            this.groupBox1.Controls.Add(this.enableUpdateLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定";
            // 
            // backupDirTextBox
            // 
            this.backupDirTextBox.Location = new System.Drawing.Point(91, 100);
            this.backupDirTextBox.Name = "backupDirTextBox";
            this.backupDirTextBox.Size = new System.Drawing.Size(163, 19);
            this.backupDirTextBox.TabIndex = 7;
            this.backupDirTextBox.TextChanged += new System.EventHandler(this.backupDirTextBox_TextChanged);
            // 
            // backupDirLabel
            // 
            this.backupDirLabel.AutoSize = true;
            this.backupDirLabel.Location = new System.Drawing.Point(12, 103);
            this.backupDirLabel.Name = "backupDirLabel";
            this.backupDirLabel.Size = new System.Drawing.Size(67, 12);
            this.backupDirLabel.TabIndex = 6;
            this.backupDirLabel.Text = "バックアップ先";
            // 
            // enableBackupCheckBox
            // 
            this.enableBackupCheckBox.AutoSize = true;
            this.enableBackupCheckBox.Location = new System.Drawing.Point(91, 78);
            this.enableBackupCheckBox.Name = "enableBackupCheckBox";
            this.enableBackupCheckBox.Size = new System.Drawing.Size(15, 14);
            this.enableBackupCheckBox.TabIndex = 5;
            this.enableBackupCheckBox.UseVisualStyleBackColor = true;
            this.enableBackupCheckBox.CheckedChanged += new System.EventHandler(this.enableBackupCheckBox_CheckedChanged);
            // 
            // enableBackupLabel
            // 
            this.enableBackupLabel.AutoSize = true;
            this.enableBackupLabel.Location = new System.Drawing.Point(12, 79);
            this.enableBackupLabel.Name = "enableBackupLabel";
            this.enableBackupLabel.Size = new System.Drawing.Size(55, 12);
            this.enableBackupLabel.TabIndex = 4;
            this.enableBackupLabel.Text = "バックアップ";
            // 
            // updateCheckTimeTextBox
            // 
            this.updateCheckTimeTextBox.Location = new System.Drawing.Point(91, 52);
            this.updateCheckTimeTextBox.Name = "updateCheckTimeTextBox";
            this.updateCheckTimeTextBox.Size = new System.Drawing.Size(28, 19);
            this.updateCheckTimeTextBox.TabIndex = 3;
            this.updateCheckTimeTextBox.TextChanged += new System.EventHandler(this.updateCheckTimeTextBox_TextChanged);
            this.updateCheckTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateCheckTimeTextBox_KeyPress);
            // 
            // updateCheckTimeLabel
            // 
            this.updateCheckTimeLabel.AutoSize = true;
            this.updateCheckTimeLabel.Location = new System.Drawing.Point(12, 55);
            this.updateCheckTimeLabel.Name = "updateCheckTimeLabel";
            this.updateCheckTimeLabel.Size = new System.Drawing.Size(73, 12);
            this.updateCheckTimeLabel.TabIndex = 2;
            this.updateCheckTimeLabel.Text = "確認間隔(分)";
            // 
            // enableUpdateCheckBox
            // 
            this.enableUpdateCheckBox.AutoSize = true;
            this.enableUpdateCheckBox.Location = new System.Drawing.Point(91, 32);
            this.enableUpdateCheckBox.Name = "enableUpdateCheckBox";
            this.enableUpdateCheckBox.Size = new System.Drawing.Size(15, 14);
            this.enableUpdateCheckBox.TabIndex = 1;
            this.enableUpdateCheckBox.UseVisualStyleBackColor = true;
            this.enableUpdateCheckBox.CheckedChanged += new System.EventHandler(this.enableUpdateCheckBox_CheckedChanged);
            // 
            // enableUpdateLabel
            // 
            this.enableUpdateLabel.AutoSize = true;
            this.enableUpdateLabel.Location = new System.Drawing.Point(12, 32);
            this.enableUpdateLabel.Name = "enableUpdateLabel";
            this.enableUpdateLabel.Size = new System.Drawing.Size(77, 12);
            this.enableUpdateLabel.TabIndex = 0;
            this.enableUpdateLabel.Text = "更新自動確認";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(116, 154);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // comfirmButton
            // 
            this.comfirmButton.Location = new System.Drawing.Point(197, 154);
            this.comfirmButton.Name = "comfirmButton";
            this.comfirmButton.Size = new System.Drawing.Size(75, 23);
            this.comfirmButton.TabIndex = 2;
            this.comfirmButton.Text = "確定";
            this.comfirmButton.UseVisualStyleBackColor = true;
            this.comfirmButton.Click += new System.EventHandler(this.comfirmButton_Click);
            // 
            // errorMessegeLabel
            // 
            this.errorMessegeLabel.AutoSize = true;
            this.errorMessegeLabel.Location = new System.Drawing.Point(125, 55);
            this.errorMessegeLabel.Name = "errorMessegeLabel";
            this.errorMessegeLabel.Size = new System.Drawing.Size(35, 12);
            this.errorMessegeLabel.TabIndex = 8;
            this.errorMessegeLabel.Text = "label1";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.comfirmButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "設定";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox updateCheckTimeTextBox;
        private System.Windows.Forms.Label updateCheckTimeLabel;
        private System.Windows.Forms.CheckBox enableUpdateCheckBox;
        private System.Windows.Forms.Label enableUpdateLabel;
        private System.Windows.Forms.TextBox backupDirTextBox;
        private System.Windows.Forms.Label backupDirLabel;
        private System.Windows.Forms.CheckBox enableBackupCheckBox;
        private System.Windows.Forms.Label enableBackupLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button comfirmButton;
        private System.Windows.Forms.Label errorMessegeLabel;
    }
}