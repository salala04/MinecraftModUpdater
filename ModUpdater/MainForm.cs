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
            logListBox.HorizontalScrollbar = true;
            // フォームサイズ変更禁止
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //ThreadExceptionイベントハンドラを追加
            Application.ThreadException +=
                new System.Threading.ThreadExceptionEventHandler(
                    Application_ThreadException);

            // INI読み込み
            inifileUtils = new InifileUtils();

            loadCommonSetting();
            updateSectionList();

            setTimetInterval();

            updateNotifyLabel.Text = "更新未確認";
            outputLog("起動完了");
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
            outputLog("Common設定読込");
            CommonSetting _setting = new CommonSetting();
            _setting = (CommonSetting)inifileUtils.loadInifile(InifileConstants.INI_COMN_NAME, _setting, typeof(CommonSetting));
            commonSetting = _setting;
        }

        private void loadSectionSetting()
        {
            outputLog(String.Format("{0}設定読込", commonSetting.selectedSection));
            SectionSetting _setting = new SectionSetting();
            _setting = (SectionSetting)inifileUtils.loadInifile(commonSetting.selectedSection, _setting, typeof(SectionSetting));
            sectionSetting = _setting;

            if (!commonSetting.selectedSection.Equals(""))
            {
                remoteUrlTextBox.Text = sectionSetting.remoteRepoUrl;
                localRepoTextBox.Text = sectionSetting.localRepoPath;
                branchTextBox.Text = sectionSetting.branch;
                userTextBox.Text = sectionSetting.gitUser;
                passwordTextBox.Text = sectionSetting.gitPassword;
                srcDirTextBox.Text = sectionSetting.srcDirPath;
                destDirTextBox.Text = sectionSetting.destDirPath;

                remoteUrlTextBox.Enabled = true;
                localRepoTextBox.Enabled = true;
                branchTextBox.Enabled = true;
                userTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                srcDirTextBox.Enabled = true;
                destDirTextBox.Enabled = true;
                modifySectionBtn.Enabled = true;
                updateBtn.Enabled = true;
                checkUpdateButton.Enabled = true;
            } else
            {
                remoteUrlTextBox.Enabled = false;
                localRepoTextBox.Enabled = false;
                branchTextBox.Enabled = false;
                userTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
                srcDirTextBox.Enabled = false;
                destDirTextBox.Enabled = false;
                modifySectionBtn.Enabled = false;
                updateBtn.Enabled = false;
                checkUpdateButton.Enabled = false;
            }
        }

        private void saveSetting()
        {
            outputLog("Common設定保存");
            inifileUtils.saveIniFile(InifileConstants.INI_COMN_NAME, commonSetting, typeof(CommonSetting));

            if (!commonSetting.selectedSection.Equals(""))
            {
                outputLog(String.Format("{0}設定保存", commonSetting.selectedSection));
                inifileUtils.saveIniFile(commonSetting.selectedSection, sectionSetting, typeof(SectionSetting));
            }
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

            setTimetInterval();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            outputLog("更新開始");

            outputLog("Git最新取得");
            Thread.Sleep(100);
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
                outputLog(String.Format("バックアップ実行 コピー元:[{0}] コピー先:[{1}]" , getDestDirPath(), commonSetting.backupDir));
                FileUtil.CopyDirectory(getDestDirPath(), Path.Combine(commonSetting.backupDir,commonSetting.selectedSection));
            }

            if (Directory.Exists(getDestDirPath())) {
                outputLog(String.Format("削除実行 削除対象:[{0}]", getDestDirPath()));
                FileUtil.DeleteReadOnlyDirectory(getDestDirPath());
            }

            outputLog(String.Format("コピー実行 コピー元:[{0}] コピー先:[{1}]", sectionSetting.srcDirPath, sectionSetting.destDirPath));
            Directory.CreateDirectory(getDestDirPath());
            FileUtil.CopyDirectory(sectionSetting.srcDirPath, sectionSetting.destDirPath);
            sectionSetting.lastCommit = gitUtil.getLastCommitString();
            notifyed = false;

            setNotExistsUpdate();
            outputLog("更新完了");
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
            if (!notifyed)
            {
                checkUpdate();
            }
        }

        private void checkUpdate()
        {
            outputLog("更新チェック開始");

            outputLog("Git最新取得中...");
            Thread.Sleep(100);
            if (gitUtil == null)
            {
                gitUtil = new GitUtil();
            }
            gitUtil.init(sectionSetting.remoteRepoUrl, sectionSetting.localRepoPath, sectionSetting.branch);
            gitUtil.fetch();
            Thread.Sleep(500);

            int commitNum = gitUtil.getCommitNum(sectionSetting.lastCommit);
            if (commitNum > 0)
            {
                outputLog("更新あり");
                setExistsUpdate();
            }
            else
            {
                outputLog("更新なし");
                setNotExistsUpdate();
            }

            outputLog("更新チェック終了");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSetting();
        }

        private void outputLog(String msg)
        {
            String time = DateTime.Now.ToString("F");
            logListBox.Items.Add(time + " : " + msg);
            logListBox.SelectedIndex = logListBox.Items.Count - 1;
        }

        private void updateCheckTimer_Tick(object sender, EventArgs e)
        {
            if (!notifyed)
            {
                checkUpdate();
            }
        }

        private void setTimetInterval()
        {
            String interval = commonSetting.updateCheckTime;

            if (!interval.Equals("")) {
                updateCheckTimer.Interval = int.Parse(interval) * 60 * 1000;
            }
            if (!interval.Equals("") && commonSetting.enableUpdateCheck.Equals(CommonConstants.VALUE_ENABLE))
            {
                updateCheckTimer.Start();
            }else
            {
                updateCheckTimer.Stop();
            }
        }

        private void setExistsUpdate()
        {
           
            notifyIcon.BalloonTipTitle = "Modが更新されました。";
            notifyIcon.BalloonTipText = sectionSetting.remoteRepoUrl;
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(10000);

            updateNotifyLabel.Text = "更新あり";
            notifyed = true;
        }

        private void setNotExistsUpdate()
        {
            updateNotifyLabel.Text = "更新なし";
        }

        //ThreadExceptionイベントハンドラ
        private static void Application_ThreadException(object sender,
            System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "エラー発生");
        }
    }
}
