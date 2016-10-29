using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace PLM.Start_commit
{
    internal static class FileHelper
    {
        private static readonly string TempPath =
            string.Format(CultureInfo.InvariantCulture, "{0}_{1}-{2}", DateTime.Today.Date.ToString("yyyy-MM-dd"),
                DateTime.Now.ToString("hh:mm:ss").Replace(':', '-'), DateTime.Now.Millisecond.ToString().Replace(':', '-'));
        public static string GetDirWithSlash(string dir)
        {
            if (dir.Trim().EndsWith(@"\"))
                return dir;

            return string.Format(CultureInfo.InvariantCulture, @"{0}\", dir);
        }

        public static string GetBackupFolderName()
        {
            return TempPath;
        }

        public static string GetLogFileName()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}.log", TempPath);
        }

        public static void MoveFiles(string sourcePath, string destPath)
        {
            var fd = new FileInfo(destPath);
            if (fd.DirectoryName != null && !Directory.Exists(fd.DirectoryName))
            {
                var fs = new FileInfo(sourcePath);
                if (fs.DirectoryName != null)
                {
                    Directory.CreateDirectory(fd.DirectoryName);
                    File.Move(sourcePath, destPath);
                }

            }
            else
                File.Move(sourcePath, destPath);
        }

        public static string[] Filter(string[] files, string pattern)
        {
            List<string> ls = new List<string>();

            foreach(string fileItem in files)
            {
                if (fileItem.EndsWith(pattern, StringComparison.OrdinalIgnoreCase))
                    ls.Add(fileItem);
            }

            return ls.ToArray();
        }
    }

}
