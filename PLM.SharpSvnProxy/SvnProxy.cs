using SharpSvn;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace PLM.SharpSvnProxy
{
    public class SvnProxy : ISvnProxy
    {
        public void DeleteFile(string pathFile)
        {
            using (var svnClient = new SvnClient())
            {
                svnClient.Delete(pathFile);
            }
        }
        public CommitFile[] GetChangedFiles(string branchPath)
        {
            var changedCommitFiles = new ConcurrentQueue<CommitFile>();

            using (var svnClient = new SvnClient())
            {
                var statusArgs = new SvnStatusArgs { Depth = SvnDepth.Infinity, RetrieveAllEntries = true };

                Collection<SvnStatusEventArgs> statuses;

                svnClient.GetStatus(branchPath, statusArgs, out statuses);

                Parallel.ForEach(statuses, (item) => {

                    if ((item.LocalContentStatus == SvnStatus.Modified ||
                        item.LocalContentStatus == SvnStatus.Added) && (item.NodeKind == SvnNodeKind.File)
                        )
                    {
                        ModifyStatus statusChange = ModifyStatus.Modified;

                        if (item.LocalContentStatus == SvnStatus.Modified)
                            statusChange = ModifyStatus.Modified;
                        else if (item.LocalContentStatus == SvnStatus.Added)
                            statusChange = ModifyStatus.Added;

                        FileInfo fi = new FileInfo(item.Path);

                        changedCommitFiles.Enqueue(new CommitFile(fi.FullName, fi.Extension,
                                statusChange));
                    }
                });
            }

            return changedCommitFiles.ToArray();
        }

        public void RenameFile(string pathFile, string newFileName)
        {
            using (var svnClient = new SvnClient())
            {
                svnClient.Move(pathFile, newFileName);
            }
        }

        public void RevertFile(string pathFile)
        {
            using (var svnClient = new SvnClient())
            {
                svnClient.Revert(pathFile);
            }
        }

        public void SetIgnoreProperty(string pathFile)
        {
            using (var svnClient = new SvnClient())
            {
                FileInfo fi = new FileInfo(pathFile);
                var value = string.Format(CultureInfo.InvariantCulture, "*.{0}", fi.Extension);

                svnClient.SetProperty(pathFile, SvnPropertyNames.SvnIgnore, value);
            }
        }
    }
}
