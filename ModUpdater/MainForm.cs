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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //タスクトレイにアイコンを表示するための設定
            //一度設定すれば、バルーンヒントを表示するたびに設定しなおす必要はない

            //バルーンヒントの設定
            //バルーンヒントのタイトル
            notifyIcon.BalloonTipTitle = "お知らせ";
            //バルーンヒントに表示するメッセージ
            notifyIcon.BalloonTipText = "DOBON.NET\nhttp://dobon.net";
            //バルーンヒントに表示するアイコン
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            //バルーンヒントを表示する
            //表示する時間をミリ秒で指定する
            notifyIcon.ShowBalloonTip(100000);
        }
    }
}
