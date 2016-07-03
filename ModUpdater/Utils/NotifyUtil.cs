using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModUpdater.Utils
{
    class NotifyUtil
    {
        private NotifyIcon notifyIcon;

        private NotifyUtil()
        {
            // デフォルトコンストラクタ無効
        }

        private NotifyUtil(NotifyIcon _notifyIcon)
        {
            this.notifyIcon = _notifyIcon;
        }
    }
}
