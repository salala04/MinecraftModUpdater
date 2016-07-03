using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModUpdater.Utils
{
    class FileUtil
    {

        public static void DeleteReadOnlyDirectory(String dirPth)
        {
            // 削除ディレクトリ情報を取得
            System.IO.DirectoryInfo delDir = new System.IO.DirectoryInfo(dirPth);

            // サブディレクトリ内も含めすべてのファイルを取得する
            System.IO.FileSystemInfo[] fileInfos = delDir.GetFileSystemInfos("*", System.IO.SearchOption.AllDirectories);

            // ファイル属性から読み取り専用属性を外す
            foreach (System.IO.FileSystemInfo fileInfo in fileInfos)
            {

                // ディレクトリまたはファイルであるかを判断する
                if ((fileInfo.Attributes & System.IO.FileAttributes.Directory) == System.IO.FileAttributes.Directory)
                {
                    // ディレクトリの場合
                    fileInfo.Attributes = System.IO.FileAttributes.Directory;
                }
                else
                {
                    // ファイルの場合
                    fileInfo.Attributes = System.IO.FileAttributes.Normal;
                }
            }

            // ディレクトリを削除（サブディレクトリを含む）
            delDir.Delete(true);
        }

        /// <summary>
        /// ディレクトリをコピーする
        /// </summary>
        /// <param name="sourceDirName">コピーするディレクトリ</param>
        /// <param name="destDirName">コピー先のディレクトリ</param>
        public static void CopyDirectory(
            string sourceDirName, string destDirName)
        {
            //コピー先のディレクトリがないときは作る
            if (!System.IO.Directory.Exists(destDirName))
            {
                System.IO.Directory.CreateDirectory(destDirName);
                //属性もコピー
                System.IO.File.SetAttributes(destDirName,
                    System.IO.File.GetAttributes(sourceDirName));
            }

            //コピー先のディレクトリ名の末尾に"\"をつける
            if (destDirName[destDirName.Length - 1] !=
                    System.IO.Path.DirectorySeparatorChar)
                destDirName = destDirName + System.IO.Path.DirectorySeparatorChar;

            //コピー元のディレクトリにあるファイルをコピー
            string[] files = System.IO.Directory.GetFiles(sourceDirName);
            foreach (string file in files)
                System.IO.File.Copy(file,
                    destDirName + System.IO.Path.GetFileName(file), true);

            //コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す
            string[] dirs = System.IO.Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
                CopyDirectory(dir, destDirName + System.IO.Path.GetFileName(dir));
        }
    }
}
