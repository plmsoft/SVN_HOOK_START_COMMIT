namespace PLM.Start_commit_notification.Commands
{
    internal abstract class BranchCommand
    {
        public abstract int Execute(string pathFile, string newFileName= "");
    }
}
