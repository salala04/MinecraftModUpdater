using ModUpdater.Constants;
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
    public partial class SettingForm : Form
    {
        public CommonSetting commonSetting { get; set; }
        public Boolean isSaved = false;

        private SettingForm()
        {

        }

        public SettingForm(CommonSetting _commonSetting)
        {
            InitializeComponent();
            // 閉じるボタン無効
            this.ControlBox = !this.ControlBox;
            // フォームサイズ変更禁止
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.commonSetting = _commonSetting;

            if (CommonConstants.VALUE_ENABLE.Equals(commonSetting.enableUpdateCheck))
            {
                enableUpdateCheckBox.Checked = true;
                updateCheckTimeTextBox.Enabled = true;
            }
            else
            {
                enableUpdateCheckBox.Checked = false;
                updateCheckTimeTextBox.Enabled = false;
            }

            if (CommonConstants.VALUE_ENABLE.Equals(commonSetting.enableBackup))
            {
                enableBackupCheckBox.Checked = true;
                backupDirTextBox.Enabled = true;
            }
            else
            {
                enableBackupCheckBox.Checked = false;
                backupDirTextBox.Enabled = false;
            }

            updateCheckTimeTextBox.Text = commonSetting.updateCheckTime;
            backupDirTextBox.Text = commonSetting.backupDir;
            ckeckUpdateTime();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            isSaved = false;
            this.Close();
        }

        private void comfirmButton_Click(object sender, EventArgs e)
        {
            isSaved = true;
            this.Close();
        }

        private void enableUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableUpdateCheckBox.Checked)
            {
                commonSetting.enableUpdateCheck = CommonConstants.VALUE_ENABLE;
                updateCheckTimeTextBox.Enabled = true;
            }else
            {
                commonSetting.enableUpdateCheck = CommonConstants.VALUE_DISABLE;
                updateCheckTimeTextBox.Enabled = false;
            }
            ckeckUpdateTime();
        }

        private void updateCheckTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            commonSetting.updateCheckTime = updateCheckTimeTextBox.Text;
            ckeckUpdateTime();
        }

        private void updateCheckTimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void enableBackupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableBackupCheckBox.Checked)
            {
                commonSetting.enableBackup = CommonConstants.VALUE_ENABLE;
                backupDirTextBox.Enabled = true;
            }
            else
            {
                commonSetting.enableBackup = CommonConstants.VALUE_DISABLE;
                backupDirTextBox.Enabled = false;
            }
        }

        private void backupDirTextBox_TextChanged(object sender, EventArgs e)
        {
            commonSetting.backupDir = backupDirTextBox.Text;
        }

        private void ckeckUpdateTime()
        {
            int num;
            if (commonSetting.updateCheckTime.Equals(""))
            {
                num = 0;
            }
            else
            {
                num = int.Parse(commonSetting.updateCheckTime);
            }

            if (!enableUpdateCheckBox.Checked)
            {
                errorMessegeLabel.Text = "";
                comfirmButton.Enabled = true;
            }
            else if (num <= 0)
            {
                errorMessegeLabel.Text = "1以上の時間を入力してください。";
                comfirmButton.Enabled = false;
            }
            else
            {
                errorMessegeLabel.Text = "";
                comfirmButton.Enabled = true;
            }
        }
    }
}
