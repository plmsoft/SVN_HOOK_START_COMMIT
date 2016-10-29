namespace PLM.Start_commit_notification.Commands
{
    internal abstract class BranchCommandFactory
    {
        public abstract BranchCommand CreateIgnoreFileCommand();
        public abstract BranchCommand CreateDeleteFileCommand();
        public abstract BranchCommand CreateRenameFileCommand();
        public abstract BranchCommand CreateRevertFileCommand();
    }
}
