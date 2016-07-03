using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModUpdater
{
    public class CommonSetting
    {
        public String selectedSection { get; set; }
        public String enableUpdateCheck { get; set; }
        public String updateCheckTime { get; set; }
        public String enableBackup { get; set; }
        public String backupDir { get; set; }
    }
}
