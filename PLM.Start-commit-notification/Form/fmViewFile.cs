using PLM.Start_commit_notification.BO;
using PLM.Start_commit_notification.Presentation;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PLM.Start_commit_notification.Form
{
    public partial class FmViewFile : System.Windows.Forms.Form
    {
        private readonly IViewFilePresentation _presenter;

        public FmViewFile(string[] args)
        {
            InitializeComponent();
            Text = Consts.CaptionWinAction;
            SetPosition();
            _presenter = new ViewFilePresentation(listViewFiles, lblCountFiles, args[0], new RenameFilePresentation());
            _presenter.FillListViewFiles();
        }


        private void SetPosition()
        {
            var display = Screen.PrimaryScreen.WorkingArea;
            var lTop = display.Height - Height;
            var lLeft = display.Width - Width;

            DesktopLocation = new Point(lLeft, lTop);
        }

        private void FmNotification_Load(object sender, EventArgs e)
        {
            _presenter.ButtonEnabled(cntMenuStripListViewFiles, toolStripMenu);
            _presenter.ShowCountFiles();
        }

        private void lnklblSelectAll_Click(object sender, EventArgs e)
        {
            _presenter.CheckedItems(true);
            _presenter.ShowCountFiles();
        }

        private void lnklblUnSelectAll_Click(object sender, EventArgs e)
        {
            _presenter.CheckedItems(false);
            _presenter.ShowCountFiles();
        }

        private void listViewFiles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            _presenter.ShowCountFiles();
            _presenter.ButtonEnabled(cntMenuStripListViewFiles, toolStripMenu);
        }

        private void pmnuIgnore_Click(object sender, EventArgs e)
        {
            _presenter.IgnoreFile();
        }

        private void pmnuDelete_Click(object sender, EventArgs e)
        {
            _presenter.DeleteFile();
        }

        private void pmnuRename_Click(object sender, EventArgs e)
        {
            _presenter.RenameFile();
        }

        private void pmnuRevert_Click(object sender, EventArgs e)
        {
            _presenter.RevertFile();
        }
    }
}
