namespace PLM.Start_commit
{
	internal class Consts
	{
		public const string HelpCommandArg = @"Using: PLM.Start-commit.exe /LocalBranch:path /Filter:*.exe;*.dll;*.config [/NotifierPath:path] [[/Log] [/LogPath:path]]";
		public const string HelpCmdArgDescr = "Description:\r\n \r\n /LocalBranch - define path to branch \r\n /Filter - define extension of files which it is need check before commit\r\n " +
            "/NotifierPath - if present define path to notifier application\r\n " +
            "/Log - if present it write log\r\n " +
            "/LogPath - it define path file of log otherwise file of log will be create in current dir";
        public const string LogDir = "LOG";
        public const string NoFiles = "There are no files to proceed";
        public const string UnsupportedFile = "Found file {0}; Status: {1}";
    }
}
