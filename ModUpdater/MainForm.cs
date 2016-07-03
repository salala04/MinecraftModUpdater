using ModUpdater.Constants;
using ModUpdater.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ModUpdater
{
    public partial class MainForm : Form
    {
        private static InifileUtils inifileUtils;
        private static CommonSetting commonSetting;
        private static SectionSetting sectionSetting;
        private static GitUtil gitUtil;
        private static Boolean notifyed = false;

        public MainForm()
        {
            InitializeComponent();

            // フォーム設定
            sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            passwordTextBox.PasswordChar = '*';

            // INI読み込み
            inifileUtils = new InifileUtils();

            loadCommonSetting();

            updateSectionList();
            loadSectionSetting();
        }

        private void addSectionBtn_Click(object sender, EventArgs e)
        {
            AddSectionForm f = new AddSectionForm();
            f.sectionList = inifileUtils.getSectionNames();
            f.ShowDialog(this);

            String section = f.addSection;
            f.Dispose();

            if (section != null)
            {
                sectionComboBox.Items.Add(section);
                sectionComboBox.SelectedItem = section;
            }
        }

        private void modifySectionBtn_Click(object sender, EventArgs e)
        {
            AddSectionForm f = new AddSectionForm();
            f.sectionList = inifileUtils.getSectionNames();
            f.ShowDialog(this);
            String sectionTmp = f.addSection;
            f.Dispose();

            if (sectionTmp != null)
            {
                inifileUtils.deleteSection(commonSetting.selectedSection);
                commonSetting.selectedSection = sectionTmp;
                sectionComboBox.Items.Add(commonSetting.selectedSection);
                sectionComboBox.SelectedItem = commonSetting.selectedSection;
                saveSetting();
            }
        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(commonSetting != null && sectionSetting != null)
            {
                saveSetting();
            }
            
            commonSetting.selectedSection = (String)sectionComboBox.SelectedItem;
            loadSectionSetting();
        }

        private void loadCommonSetting()
        {
            CommonSetting _setting = new CommonSetting();
            _setting = (CommonSetting)inifileUtils.loadInifile(InifileConstants.INI_COMN_NAME, _setting, typeof(CommonSetting));
            commonSetting = _setting;
        }

        private void loadSectionSetting()
        {
            SectionSetting _setting = new SectionSetting();
            _setting = (SectionSetting)inifileUtils.loadInifile(commonSetting.selectedSection, _setting, typeof(SectionSetting));
            sectionSetting = _setting;

            remoteUrlTextBox.Text = sectionSetting.remoteRepoUrl;
            localRepoTextBox.Text = sectionSetting.localRepoPath;
            branchTextBox.Text = sectionSetting.branch;
            userTextBox.Text = sectionSetting.gitUser;
            passwordTextBox.Text = sectionSetting.gitPassword;
            srcDirTextBox.Text = sectionSetting.srcDirPath;
            destDirTextBox.Text = sectionSetting.destDirPath;
        }

        private void saveSetting()
        {
            inifileUtils.saveIniFile(InifileConstants.INI_COMN_NAME, commonSetting, typeof(CommonSetting));
            inifileUtils.saveIniFile(commonSetting.selectedSection, sectionSetting, typeof(SectionSetting));
        }

        private void updateSectionList()
        {
            sectionComboBox.Items.Clear();

            List<string> list = inifileUtils.getSectionNames();
            foreach (String val in list)
            {
                if (!InifileConstants.INI_COMN_NAME.Equals(val))
                {
                    sectionComboBox.Items.Add(val);
                }
            }

            sectionComboBox.SelectedItem = commonSetting.selectedSection;
        }

        private void remoteUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionSetting.remoteRepoUrl = remoteUrlTextBox.Text;
        }

        private void localRepoTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionSetting.localRepoPath = localRepoTextBox.Text;
        }

        private void srcDirTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionSetting.srcDirPath = srcDirTextBox.Text;
        }

        private void destDirTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionSetting.destDirPath = destDirTextBox.Text;
        }

        private void branchTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionSetting.branch = branchTextBox.Text;
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionSetting.gitUser = userTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionSetting.gitPassword = passwordTextBox.Text;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSetting();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSetting();
            this.Close();
        }

        private void settingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingForm f = new SettingForm(commonSetting);

            f.ShowDialog(this);
            if (f.isSaved)
            {
                commonSetting = f.commonSetting;
            }
            f.Dispose();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (gitUtil == null)
            {
                gitUtil = new GitUtil();
            }
            gitUtil.init(sectionSetting.remoteRepoUrl, sectionSetting.localRepoPath, sectionSetting.branch);
            gitUtil.fetch();
            Thread.Sleep(500);

            if (CommonConstants.VALUE_ENABLE.Equals(commonSetting.enableBackup)
                & Directory.Exists(getDestDirPath()))
            {
                FileUtil.CopyDirectory(getDestDirPath(), commonSetting.backupDir);
            }

            if (Directory.Exists(getDestDirPath())) {
                FileUtil.DeleteReadOnlyDirectory(getDestDirPath());
            }

            Directory.CreateDirectory(getDestDirPath());
            FileUtil.CopyDirectory(sectionSetting.srcDirPath, sectionSetting.destDirPath);
            sectionSetting.lastCommit = gitUtil.getLastCommitString();
            notifyed = false;
        }

        private String getDestDirPath()
        {
            if (sectionSetting.destDirPath.Equals(""))
            {
                String appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                sectionSetting.destDirPath = Path.Combine(appdata, CommonConstants.MOD_DIR_SUFFIX);
                destDirTextBox.Text = sectionSetting.destDirPath;
                return Path.Combine(appdata, CommonConstants.MOD_DIR_SUFFIX);
            }
            else
            {
                return sectionSetting.destDirPath;
            }
        }

        private void checkUpdateButton_Click(object sender, EventArgs e)
        {
            checkUpdate();
        }

        private void checkUpdate()
        {
            if (gitUtil == null)
            {
                gitUtil = new GitUtil();
            }
            gitUtil.init(sectionSetting.remoteRepoUrl, sectionSetting.localRepoPath, sectionSetting.branch);
            gitUtil.fetch();

            int commitNum = gitUtil.getCommitNum(sectionSetting.lastCommit);
            if (commitNum > 0)
            {
                notifyIcon.BalloonTipTitle = "Modが更新されました。";
                notifyIcon.BalloonTipText = sectionSetting.remoteRepoUrl;
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(10000);

                notifyed = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSetting();
        }
    }
}
