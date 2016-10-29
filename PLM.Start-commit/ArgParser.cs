using System;

namespace PLM.Start_commit
{
   internal class ArgParser
	{
		private string[] _arg;
        private string _svnPath;
        private string _filterCommitFiles;
        private bool TryGetValue(string pattern, out string value)
        {
            bool result = false;
            value = string.Empty;

            foreach(string item in _arg)
            {
                var inx = item.IndexOf(pattern, StringComparison.OrdinalIgnoreCase);
                if ( inx >= 0)
                {
                    result = true;
                    value = item.Substring(inx + pattern.Length).Trim(new[] {']', '['});
                    break;
                }
            }

            return result;
        }
		public ArgParser(string[] arg)
		{
			_arg = arg;
		}

		public bool Parser()
		{
			if (_arg.Length == 0)
				return false;

            if (!TryGetValue(CommandArg.Svn, out _svnPath))
                return false;

            if (!TryGetValue(CommandArg.FilterCommitFiles, out _filterCommitFiles))
                return false;

            return true;
		}

        public string SvnPath { get { return _svnPath; } }
        public string FilterCommitFiles { get { return _filterCommitFiles; } }
        public string NotifierPath {
            get {
                    string value;
                    TryGetValue(CommandArg.NotifierPath, out value);
                    return value;
                }
        }
        public bool IsLog {
            get {
                    string value;
                    if (TryGetValue(CommandArg.Log, out value))
                        return true;
                    return false;
                }
        }
        public string LogPath {
            get {
                    string value;
                    TryGetValue(CommandArg.LogPath, out value);
                    return value;
                }
        }
    }
}
