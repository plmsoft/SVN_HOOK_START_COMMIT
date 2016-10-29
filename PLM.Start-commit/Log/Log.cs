using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Linq;

namespace PLM.Start_commit
{
    internal class Log
    {
        private readonly Queue<MessageLogItem> _cacheLogMessage = new Queue<MessageLogItem>();
        private static Log _instance = null;
        private bool _isLog;
        private string _logPath;

        private Log()
        {
        }

        public static Log Logger()
        {
            if (_instance != null) return _instance;

            Log il = new Log();

            Interlocked.CompareExchange(ref _instance, il, null);

            return _instance;
        }

        public bool IsLog { get { return _isLog; } set { _isLog = value; } }
        public string LogPath { get { return _logPath; } set {_logPath = value; }}
        public void Write(MessageLogItem msg)
        {
            if (IsLog)
                _cacheLogMessage.Enqueue(msg);
        }

        private IEnumerable<MessageLogItem> LogItems
        {
            get { return _cacheLogMessage; }
        }

        private void SaveLogToFile(string pathLog)
        {
            if (pathLog.Length == 0)
            {
                FileInfo fi = new FileInfo(Assembly.GetExecutingAssembly().Location);

                pathLog = string.Format(CultureInfo.InvariantCulture, "{0}{1}", FileHelper.GetDirWithSlash(fi.DirectoryName), FileHelper.GetDirWithSlash(Consts.LogDir));
            }
            else
                pathLog = string.Format(CultureInfo.InvariantCulture, "{0}", FileHelper.GetDirWithSlash(pathLog));

            string fileName = string.Format(CultureInfo.InvariantCulture, "{0}{1}", pathLog, FileHelper.GetLogFileName());

            var logLines = LogItems.Select(d => string.Format(CultureInfo.InvariantCulture, "{0} : {1}", d.TypeMessage.ToString().PadRight(10), d.Message)).ToArray();

            try
            {
                if (logLines.Length > 0)
                {
                    Directory.CreateDirectory(pathLog);
                    File.WriteAllLines(fileName, logLines.ToArray());
                }
            }
            catch
            {
            }
        }

        public void Flush()
        {
          SaveLogToFile(LogPath);
        }

    }
}
