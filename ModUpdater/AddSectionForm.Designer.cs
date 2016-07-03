namespace ModUpdater
{
    partial class AddSectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSectionForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.comfirmBtn = new System.Windows.Forms.Button();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.attentionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(44, 69);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "閉じる";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // comfirmBtn
            // 
            this.comfirmBtn.Location = new System.Drawing.Point(125, 69);
            this.comfirmBtn.Name = "comfirmBtn";
            this.comfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.comfirmBtn.TabIndex = 1;
            this.comfirmBtn.Text = "確定";
            this.comfirmBtn.UseVisualStyleBackColor = true;
            this.comfirmBtn.Click += new System.EventHandler(this.comfirmBtn_Click);
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Location = new System.Drawing.Point(12, 32);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(188, 19);
            this.sectionTextBox.TabIndex = 2;
            this.sectionTextBox.TextChanged += new System.EventHandler(this.sectionTextBox_TextChanged);
            // 
            // attentionLabel
            // 
            this.attentionLabel.AutoSize = true;
            this.attentionLabel.Location = new System.Drawing.Point(12, 54);
            this.attentionLabel.Name = "attentionLabel";
            this.attentionLabel.Size = new System.Drawing.Size(50, 12);
            this.attentionLabel.TabIndex = 3;
            this.attentionLabel.Text = "メッセージ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "設定名";
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comfirmBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(this.attentionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSectionForm";
            this.Text = "設定名編集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button comfirmBtn;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.Label attentionLabel;
        private System.Windows.Forms.Label label1;
    }
}