using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModUpdater
{
    public partial class AddSectionForm : Form
    {
        public List<String> sectionList { set; private get; }
        public String addSection { private set; get; }

        public AddSectionForm()
        {
            InitializeComponent();
            this.ControlBox = !this.ControlBox;
            // 閉じるボタン無効
            this.checkSectionName(sectionTextBox.Text);
            // フォームサイズ変更禁止
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void sectionTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach(String val in sectionList)
            {
                checkSectionName(val);
            }
        }

        private void checkSectionName(String val)
        {
            if (sectionTextBox.Text.Equals(""))
            {
                attentionLabel.Text = "設定名が空白です";
                comfirmBtn.Enabled = false;
            }
            else if (sectionTextBox.Text.Equals(val)
                || InifileConstants.INI_COMN_NAME.Equals(sectionTextBox.Text))
            {
                attentionLabel.Text = "すでに割り当てられている設定名です。";
                comfirmBtn.Enabled = false;
            }
            else
            {
                attentionLabel.Text = "";
                comfirmBtn.Enabled = true;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comfirmBtn_Click(object sender, EventArgs e)
        {
            this.addSection = sectionTextBox.Text;
            this.Close();
        }
    }
}
