using PLM.Start_commit_notification.Form;
using System.Windows.Forms;

namespace PLM.Start_commit_notification.Presentation
{
    internal class RenameFilePresentation : IRenameFilePresentation
    {
        public bool RenameFileForm(string oldFileName, out string newFileName)
        {
            newFileName = string.Empty;

            using (var fmRenameFile = new fmRenameFile())
            {
                fmRenameFile.OldFileName = oldFileName;

                if (fmRenameFile.ShowDialog() == DialogResult.OK)
                {
                    newFileName = fmRenameFile.NewFileName;
                    return true;
                }

                return false;
            }
        }
    }
}
