using System;

namespace ModUpdater
{
    public class SectionSetting
    {
        public String remoteRepoUrl { get; set; }
        public String localRepoPath { get; set; }
        public String branch { get; set; }
        public String gitUser { get; set; }
        public String gitPassword { get; set; }
        public String lastCommit { get; set; }
        public String srcDirPath { get; set; }
        public String destDirPath { get; set; }
    }
}
