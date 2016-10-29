namespace PLM.SharpSvnProxy
{
    public interface ISvnProxy
    {
        CommitFile[] GetChangedFiles(string branchPath);
        void SetIgnoreProperty(string pathFile);
        void DeleteFile(string pathFile);
        void RenameFile(string pathFile, string newFileName);
        void RevertFile(string pathFile);
    }
}
