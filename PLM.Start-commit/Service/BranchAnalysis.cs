using PLM.SharpSvnProxy;
using System.Collections.Generic;

namespace PLM.Start_commit
{
    internal class BranchAnalysis
	{
		private readonly string _branchPath;
        private readonly string _filterCommitFiles;
        private readonly ISvnProxy _svnProxy;

        public BranchAnalysis(string branchPath, string filterCommitFiles)
		{
			_branchPath = branchPath;
            _filterCommitFiles = filterCommitFiles;
            _svnProxy = new SvnProxy();
        }

        public CommitFile[] GetUnCommitChangedFiles()
        {
            var changedFiles = _svnProxy.GetChangedFiles(_branchPath);

            var ls = new List<CommitFile>(changedFiles.Length);

            foreach(CommitFile item in changedFiles)
            {
                if (_filterCommitFiles.Contains(item.Extension.TrimStart('.')))
                    ls.Add(item);
            }

            return ls.ToArray();
        }

    }
}
