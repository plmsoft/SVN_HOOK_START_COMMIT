namespace PLM.Start_commit_notification.Presentation
{
    internal interface IRenameFilePresentation
    {
        bool RenameFileForm(string oldFileName, out string newFileNAme);
    }
}
