using PLM.SharpSvnProxy;
using PLM.Start_commit_notification.BO;
using System;
using System.Windows.Forms;

namespace PLM.Start_commit_notification.Commands.Svn
{
    internal class SvnRevertFileCommand : BranchCommand
    {
        public override int Execute(string pathFile, string newFileName = "")
        {
            try
            {
                var svnProxy = new SvnProxy();
                svnProxy.RevertFile(pathFile);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Consts.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }
    }
}
