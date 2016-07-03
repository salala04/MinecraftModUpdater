using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ModUpdater.Utils
{

    /// <summary>
    /// iniファイル取り扱いのためのユーティリティクラス
    /// </summary>
    class InifileUtils
    {
        /// <summary>
        /// iniファイルのパスを保持
        /// </summary>
        private String filePath { get; set; }

        [DllImport("KERNEL32.DLL")]
        public static extern uint
            GetPrivateProfileString(string lpAppName,
            string lpKeyName, string lpDefault,
            StringBuilder lpReturnedString, uint nSize,
            string lpFileName);

        [DllImport("KERNEL32.DLL")]
        public static extern uint
            GetPrivateProfileInt(string lpAppName,
            string lpKeyName, int nDefault, string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpstring,
            string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSectionNames(byte[]
            lpszReturnBuffer, int nSize, string lpFileName);

        /// <summary>
        /// コンストラクタ(デフォルト)
        /// </summary>
        public InifileUtils()
        {
            this.filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, InifileConstants.INI_FILE_NAME);
        }

        /// <summary>
        /// コンストラクタ(fileパスを指定する場合)
        /// </summary>
        /// <param name="filePath">iniファイルパス</param>
        public InifileUtils(String filePath)
        {
            this.filePath = filePath;
        }

        /// <summary>
        /// iniファイル中のセクションのキーを指定して、文字列を返す
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public String getValueString(String section, String key)
        {
            StringBuilder sb = new StringBuilder(1024);

            GetPrivateProfileString(
                section,
                key,
                "",
                sb,
                Convert.ToUInt32(sb.Capacity),
                filePath);

            return sb.ToString();
        }

        /// <summary>
        /// iniファイル中のセクションのキーを指定して、整数値を返す
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int getValueInt(String section, String key)
        {
            return (int)GetPrivateProfileInt(section, key, 0, filePath);
        }

        /// <summary>
        /// 指定したセクション、キーに数値を書き込む
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public void setValue(String section, String key, int val)
        {
            setValue(section, key, val.ToString());
        }

        /// <summary>
        /// 指定したセクション、キーに文字列を書き込む
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public void setValue(String section, String key, String val)
        {
            WritePrivateProfileString(section, key, val, filePath);
        }

        /// <summary>
        /// セクション一覧取得
        /// </summary>
        /// <param name="iniFile"></param>
        /// <returns></returns>
        public List<string> getSectionNames()
        {
            byte[] buffer = new byte[2048];
            GetPrivateProfileSectionNames(buffer, 2048, this.filePath);
            string[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');

            List<string> result = new List<string>();
            foreach (String entry in tmp)
            {
                result.Add(entry);
            }

            return result;
        }

        /// <summary>
        /// 指定セクション削除
        /// </summary>
        /// <param name="section"></param>
        public void deleteSection(String section)
        {

            WritePrivateProfileString(section, null, null, this.filePath);
        }

        /// <summary>
        /// Iniファイルから指定セクションの情報をクラスへ格納
        /// </summary>
        /// <param name="inifileUtils"></param>
        /// <param name="targetobj"></param>
        /// <param name="t"></param>
        public object loadInifile(String section, object targetobj, Type t)
        {

            MemberInfo[] members = t.GetMembers(
                System.Reflection.BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.DeclaredOnly);

            foreach (MemberInfo m in members)
            {
                if (m.MemberType.ToString().Equals("Property"))
                {
                    PropertyInfo pr = t.GetProperty(m.Name);
                    String str = getValueString(section, m.Name);
                    if(str == null)
                    {
                        pr.SetValue(targetobj, "");
                    }else
                    {
                        pr.SetValue(targetobj, str);
                    }
                    
                }
            }

            return targetobj;
        }

        /// <summary>
        /// Iniファイルから指定セクションの情報をクラスへ格納
        /// </summary>
        /// <param name="inifileUtils"></param>
        /// <param name="targetobj"></param>
        /// <param name="t"></param>
        public void saveIniFile(String section, object targetobj, Type t)
        {
            MemberInfo[] members = t.GetMembers(
                System.Reflection.BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.DeclaredOnly);

            foreach (MemberInfo m in members)
            {
                if (m.MemberType.ToString().Equals("Property"))
                {
                    PropertyInfo pr = t.GetProperty(m.Name);
                    setValue(section, m.Name, (String)pr.GetValue(targetobj));
                }
            }
        }
    }
}
