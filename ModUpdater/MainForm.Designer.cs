namespace ModUpdater
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.addSectionBtn = new System.Windows.Forms.Button();
            this.modifySectionBtn = new System.Windows.Forms.Button();
            this.localRepoTextBox = new System.Windows.Forms.TextBox();
            this.srcDirTextBox = new System.Windows.Forms.TextBox();
            this.destDirTextBox = new System.Windows.Forms.TextBox();
            this.remoteUrlText = new System.Windows.Forms.Label();
            this.localRepoText = new System.Windows.Forms.Label();
            this.srcDirText = new System.Windows.Forms.Label();
            this.destDirText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordText = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.remoteUrlTextBox = new System.Windows.Forms.TextBox();
            this.branchText = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.checkUpdateButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.settingGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MinecraftModUpdate";
            this.notifyIcon.Visible = true;
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(13, 45);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(121, 20);
            this.sectionComboBox.TabIndex = 2;
            this.sectionComboBox.SelectedIndexChanged += new System.EventHandler(this.sectionComboBox_SelectedIndexChanged);
            // 
            // addSectionBtn
            // 
            this.addSectionBtn.Location = new System.Drawing.Point(216, 45);
            this.addSectionBtn.Name = "addSectionBtn";
            this.addSectionBtn.Size = new System.Drawing.Size(65, 20);
            this.addSectionBtn.TabIndex = 3;
            this.addSectionBtn.Text = "追加";
            this.addSectionBtn.UseVisualStyleBackColor = true;
            this.addSectionBtn.Click += new System.EventHandler(this.addSectionBtn_Click);
            // 
            // modifySectionBtn
            // 
            this.modifySectionBtn.Location = new System.Drawing.Point(145, 45);
            this.modifySectionBtn.Name = "modifySectionBtn";
            this.modifySectionBtn.Size = new System.Drawing.Size(65, 20);
            this.modifySectionBtn.TabIndex = 4;
            this.modifySectionBtn.Text = "変更";
            this.modifySectionBtn.UseVisualStyleBackColor = true;
            this.modifySectionBtn.Click += new System.EventHandler(this.modifySectionBtn_Click);
            // 
            // localRepoTextBox
            // 
            this.localRepoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.localRepoTextBox.Location = new System.Drawing.Point(114, 43);
            this.localRepoTextBox.Name = "localRepoTextBox";
            this.localRepoTextBox.Size = new System.Drawing.Size(327, 19);
            this.localRepoTextBox.TabIndex = 6;
            this.localRepoTextBox.TextChanged += new System.EventHandler(this.localRepoTextBox_TextChanged);
            // 
            // srcDirTextBox
            // 
            this.srcDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srcDirTextBox.Location = new System.Drawing.Point(121, 175);
            this.srcDirTextBox.Name = "srcDirTextBox";
            this.srcDirTextBox.Size = new System.Drawing.Size(326, 19);
            this.srcDirTextBox.TabIndex = 7;
            this.srcDirTextBox.TextChanged += new System.EventHandler(this.srcDirTextBox_TextChanged);
            // 
            // destDirTextBox
            // 
            this.destDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destDirTextBox.Location = new System.Drawing.Point(120, 200);
            this.destDirTextBox.Name = "destDirTextBox";
            this.destDirTextBox.Size = new System.Drawing.Size(327, 19);
            this.destDirTextBox.TabIndex = 8;
            this.destDirTextBox.TextChanged += new System.EventHandler(this.destDirTextBox_TextChanged);
            // 
            // remoteUrlText
            // 
            this.remoteUrlText.AutoSize = true;
            this.remoteUrlText.Location = new System.Drawing.Point(17, 21);
            this.remoteUrlText.Name = "remoteUrlText";
            this.remoteUrlText.Size = new System.Drawing.Size(67, 12);
            this.remoteUrlText.TabIndex = 9;
            this.remoteUrlText.Text = "リモートURL：";
            // 
            // localRepoText
            // 
            this.localRepoText.AutoSize = true;
            this.localRepoText.Location = new System.Drawing.Point(17, 46);
            this.localRepoText.Name = "localRepoText";
            this.localRepoText.Size = new System.Drawing.Size(91, 12);
            this.localRepoText.TabIndex = 10;
            this.localRepoText.Text = "ローカルリポジトリ：";
            // 
            // srcDirText
            // 
            this.srcDirText.AutoSize = true;
            this.srcDirText.Location = new System.Drawing.Point(23, 178);
            this.srcDirText.Name = "srcDirText";
            this.srcDirText.Size = new System.Drawing.Size(50, 12);
            this.srcDirText.TabIndex = 11;
            this.srcDirText.Text = "コピー元：";
            // 
            // destDirText
            // 
            this.destDirText.AutoSize = true;
            this.destDirText.Location = new System.Drawing.Point(23, 203);
            this.destDirText.Name = "destDirText";
            this.destDirText.Size = new System.Drawing.Size(50, 12);
            this.destDirText.TabIndex = 12;
            this.destDirText.Text = "コピー先：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.SaveToolStripMenuItem.Text = "保存";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "終了";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem1});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // settingToolStripMenuItem1
            // 
            this.settingToolStripMenuItem1.Name = "settingToolStripMenuItem1";
            this.settingToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.settingToolStripMenuItem1.Text = "設定";
            this.settingToolStripMenuItem1.Click += new System.EventHandler(this.settingToolStripMenuItem1_Click);
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingGroupBox.Controls.Add(this.groupBox1);
            this.settingGroupBox.Controls.Add(this.destDirText);
            this.settingGroupBox.Controls.Add(this.srcDirText);
            this.settingGroupBox.Controls.Add(this.srcDirTextBox);
            this.settingGroupBox.Controls.Add(this.destDirTextBox);
            this.settingGroupBox.Location = new System.Drawing.Point(13, 71);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(459, 235);
            this.settingGroupBox.TabIndex = 14;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "設定";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordText);
            this.groupBox1.Controls.Add(this.userText);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.localRepoTextBox);
            this.groupBox1.Controls.Add(this.userTextBox);
            this.groupBox1.Controls.Add(this.localRepoText);
            this.groupBox1.Controls.Add(this.branchTextBox);
            this.groupBox1.Controls.Add(this.remoteUrlTextBox);
            this.groupBox1.Controls.Add(this.branchText);
            this.groupBox1.Controls.Add(this.remoteUrlText);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 154);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Git設定";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(17, 121);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(52, 12);
            this.passwordText.TabIndex = 18;
            this.passwordText.Text = "パスワード";
            // 
            // userText
            // 
            this.userText.AutoSize = true;
            this.userText.Location = new System.Drawing.Point(17, 96);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(45, 12);
            this.userText.TabIndex = 17;
            this.userText.Text = "ユーザー";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(115, 118);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 19);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(115, 93);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 19);
            this.userTextBox.TabIndex = 15;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // branchTextBox
            // 
            this.branchTextBox.Location = new System.Drawing.Point(115, 68);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(100, 19);
            this.branchTextBox.TabIndex = 14;
            this.branchTextBox.TextChanged += new System.EventHandler(this.branchTextBox_TextChanged);
            // 
            // remoteUrlTextBox
            // 
            this.remoteUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteUrlTextBox.Location = new System.Drawing.Point(115, 18);
            this.remoteUrlTextBox.Name = "remoteUrlTextBox";
            this.remoteUrlTextBox.Size = new System.Drawing.Size(326, 19);
            this.remoteUrlTextBox.TabIndex = 5;
            this.remoteUrlTextBox.TextChanged += new System.EventHandler(this.remoteUrlTextBox_TextChanged);
            // 
            // branchText
            // 
            this.branchText.AutoSize = true;
            this.branchText.Location = new System.Drawing.Point(17, 71);
            this.branchText.Name = "branchText";
            this.branchText.Size = new System.Drawing.Size(40, 12);
            this.branchText.TabIndex = 13;
            this.branchText.Text = "ブランチ";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(395, 312);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(65, 20);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "更新";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // checkUpdateButton
            // 
            this.checkUpdateButton.Location = new System.Drawing.Point(324, 312);
            this.checkUpdateButton.Name = "checkUpdateButton";
            this.checkUpdateButton.Size = new System.Drawing.Size(65, 20);
            this.checkUpdateButton.TabIndex = 16;
            this.checkUpdateButton.Text = "更新確認";
            this.checkUpdateButton.UseVisualStyleBackColor = true;
            this.checkUpdateButton.Click += new System.EventHandler(this.checkUpdateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 355);
            this.Controls.Add(this.checkUpdateButton);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.settingGroupBox);
            this.Controls.Add(this.modifySectionBtn);
            this.Controls.Add(this.addSectionBtn);
            this.Controls.Add(this.sectionComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ModUpdater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.settingGroupBox.ResumeLayout(false);
            this.settingGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.Button addSectionBtn;
        private System.Windows.Forms.Button modifySectionBtn;
        private System.Windows.Forms.TextBox remoteUrlTextBox;
        private System.Windows.Forms.TextBox localRepoTextBox;
        private System.Windows.Forms.TextBox srcDirTextBox;
        private System.Windows.Forms.TextBox destDirTextBox;
        private System.Windows.Forms.Label remoteUrlText;
        private System.Windows.Forms.Label localRepoText;
        private System.Windows.Forms.Label srcDirText;
        private System.Windows.Forms.Label destDirText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem1;
        private System.Windows.Forms.GroupBox settingGroupBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label userText;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.Label branchText;
        private System.Windows.Forms.Button checkUpdateButton;
    }
}

