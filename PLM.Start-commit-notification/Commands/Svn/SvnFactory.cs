namespace PLM.Start_commit_notification.Commands.Svn
{
    internal class SvnFactory : BranchCommandFactory
    {
        public override BranchCommand CreateDeleteFileCommand()
        {
           return new SvnDeleteFileCommand();
        }

        public override BranchCommand CreateIgnoreFileCommand()
        {
            return new SvnIgnoreFileCommand();
        }

        public override BranchCommand CreateRenameFileCommand()
        {
            return new SvnRenameFileCommand();
        }

        public override BranchCommand CreateRevertFileCommand()
        {
            return new SvnRevertFileCommand();
        }
    }
}
