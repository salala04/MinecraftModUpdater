using LibGit2Sharp;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ModUpdater
{
    /// <summary>
    /// Git操作クラス
    /// LibGit2Sharpを使用
    /// 参考：https://github.com/libgit2/libgit2sharp
    /// </summary>
    public class GitUtil
    {
        
        private const String GIT_EXT = ".git";

        public Repository repo { get; private set; }

        private String url  = null;
        private String path = null;

        /// <summary>
        /// 初期化処理<br/>
        /// ローカルリポジトリがなければ作成
        /// </summary>
        /// <param name="url">リモートリポジトリURL</param>
        /// <param name="path">ローカルリポジトリ</param>
        public void init(String url, String path, String branch)
        {
            if (!Directory.Exists(Path.Combine(path, GIT_EXT)))
            {
                var co = new CloneOptions();
                co.BranchName = branch;
                Repository.Clone(url, path, co);
            }

            this.repo = new Repository(path);
            this.url  = url;
            this.path = path;
        }

        /// <summary>
        /// 初期化処理<br/>
        /// ローカルリポジトリがなければ作成
        /// </summary>
        /// <param name="url">リモートリポジトリURL</param>
        /// <param name="path">ローカルリポジトリ</param>
        /// <param name="user">ユーザー名</param>
        /// <param name="password">パスワード</param>
        public void init(String url, String path, String branch, String user, String password)
        {
            if (!Directory.Exists(Path.Combine(path, GIT_EXT)))
            {
                var co = new CloneOptions();
                co.CredentialsProvider = (_path, _user, _cred) => new UsernamePasswordCredentials { Username = user, Password = password };
                co.BranchName = branch;
                Repository.Clone(url, path, co);
            }

            this.repo = new Repository(path);
            this.url  = url;
            this.path = path;
        }

        public void fetch()
        {
            Remote remote = repo.Network.Remotes["origin"];
            repo.Network.Fetch(remote);
        }

        public int getCommitNum(String commitNum)
        {
            var filter = new CommitFilter { SortBy = CommitSortStrategies.Topological | CommitSortStrategies.Reverse };

            int i = 0;
            foreach (Commit c in repo.Commits.QueryBy(filter))
            {
                if (commitNum.Equals(c.Id.ToString()))
                {
                    return i;
                }
                
                i++;
            }

            return i;
        }

        public String getLastCommitString()
        {
            var filter = new CommitFilter { SortBy = CommitSortStrategies.Topological | CommitSortStrategies.Reverse };

            String str = "";
            foreach (Commit c in repo.Commits.QueryBy(filter))
            {
                str = c.Id.ToString();
                break;
            }
            return str;
        }
    }
}
