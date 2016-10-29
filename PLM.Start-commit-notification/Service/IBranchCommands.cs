namespace PLM.Start_commit_notification.Service
{
    internal interface IBranchCommands
    {
        bool IgnoreFile(string[] files);
        bool DeleteFile(string[] files);
        bool RenameFile(string file, string newFileName);
		bool RevertFile(string[] files);
    }
}
