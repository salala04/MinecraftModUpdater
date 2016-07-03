using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModUpdater
{
    class InifileConstants
    {
        // Setting.ini用共通定義
        public const String INI_FILE_NAME = "ModUpdater.ini";
        public const String INI_COMN_NAME = "Common";
        public const String KEY_SELECT_SECTION = "selectedSection";

        // Setting.ini用キー定義
        public const String KEY_REMOTE_REPO_URL = "remoteRepoUrl";
        public const String KEK_LOCAL_REPO_URL = "localRepoPath";
        public const String KEY_GIT_USER = "gitUser";
        public const String KEY_GIT_PASSWORD = "gitPassword";
    }
}
