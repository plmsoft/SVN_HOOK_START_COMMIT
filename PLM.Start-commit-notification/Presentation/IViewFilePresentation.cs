using System.Windows.Forms;

namespace PLM.Start_commit_notification.Presentation
{
    internal interface IViewFilePresentation
    {
        void FillListViewFiles();
        void SetAppearance();
        void ButtonEnabled(ContextMenuStrip mnu, ToolStrip tsmnu);
        void ShowCountFiles();
        void CheckedItems(bool check);
        void IgnoreFile();
        void DeleteFile();
        void RenameFile();
        void RevertFile();
    }
}
