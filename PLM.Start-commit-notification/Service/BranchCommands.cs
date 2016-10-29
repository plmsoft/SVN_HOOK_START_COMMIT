using PLM.Start_commit_notification.Commands;

namespace PLM.Start_commit_notification.Service
{
    internal class BranchCommands : IBranchCommands
    {
        private BranchCommandFactory _branch;

        public BranchCommands(BranchCommandFactory branchFactory)
        {
            _branch = branchFactory;
        }

        public bool DeleteFile(string[] files)
        {
			var result = true;
			foreach (var item in files)
			{
				var cr = _branch.CreateDeleteFileCommand().Execute(item);
				if (cr == 1) result = false;
			}
			return result;
        }

        public bool IgnoreFile(string[] files)
        {
			var result = true;
			foreach (var item in files)
			{
				var cr = _branch.CreateIgnoreFileCommand().Execute(item);
				if (cr == 1) result = false;
			}
			return result;
		}

        public bool RenameFile(string file, string newFileName)
        {
			var cr = _branch.CreateRenameFileCommand().Execute(file, newFileName);
			return (cr == 0);
		}

        public bool RevertFile(string[] files)
        {
			var result = true;
			foreach (var item in files)
			{
				var cr = _branch.CreateRevertFileCommand().Execute(item);
				if (cr == 1) result = false;
			}
			return result;
		}
    }
}
