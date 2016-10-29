using System;

namespace PLM.SharpSvnProxy
{
    public enum ModifyStatus { Added, Modified, Deleted }

	[Serializable]
	public class CommitFile
	{
		public string Location { get; set; }
		public string Extension { get; set; }
		public ModifyStatus Status { get; set; }

		public CommitFile() { }

		public CommitFile(string location, string ext, ModifyStatus status)
		{
			Location = location;
			Extension = ext;
			Status = status;
		}
	}

}
