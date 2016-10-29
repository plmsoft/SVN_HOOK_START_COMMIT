using PLM.Start_commit_notification.BO;
using System;
using System.IO;
using System.Windows.Forms;

namespace PLM.Start_commit_notification.Form
{
    public partial class fmRenameFile : System.Windows.Forms.Form
    {
        private string _oldFileName;
        public fmRenameFile()
        {
            InitializeComponent();
            Text = Consts.CaptionRenameFile;
        }

        public string NewFileName { get { return txtNewName.Text; } }
        public string OldFileName {

            get { return _oldFileName;}
            set { lbOldName.Text = string.Format(lbOldName.Text, value); _oldFileName = value; }
        }

        private bool IsNameValid()
        {
            if (txtNewName.Text.Length == 0)
            {
                newNameErrorProvider.SetError(this.txtNewName, Consts.MessageItemIsRequred);
                return false;
            }

            if (txtNewName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) > 0)
            {
                newNameErrorProvider.SetError(this.txtNewName, Consts.MessageUnsupportedSymbol);
                return false;
            }

            var fi = new FileInfo(txtNewName.Text);
            if (fi.Extension.Length == 0)
            {
                newNameErrorProvider.SetError(this.txtNewName, Consts.MessageNofileExtension);
                return false;
            }

            return true;
        }
        private void txtNewName_Validated(object sender, EventArgs e)
        {
            if (IsNameValid())
            {
                newNameErrorProvider.SetError(this.txtNewName, String.Empty);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!IsNameValid())
            {
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
