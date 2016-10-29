using PLM.SharpSvnProxy;
using System;
using System.Globalization;
using System.Text;

namespace PLM.Start_commit
{

    class Program
    {
		[STAThread]
        static int Main(string[] args)
		{
			var argParser = new ArgParser(args);

			if (!argParser.Parser())
			{
				Help.Show();
				return 1;
			}

            Log.Logger().IsLog = argParser.IsLog;
            Log.Logger().LogPath = argParser.LogPath;
            Log.Logger().Write(new MessageLogItem(string.Format(CultureInfo.InvariantCulture, Events.StartProcess, DateTime.Now), TypeLogItem.Info));

            try
            {
                Log.Logger().Write(new MessageLogItem(string.Format(CultureInfo.InvariantCulture, Events.StartCheckBranch, DateTime.Now), TypeLogItem.Info));

                var ba = new BranchAnalysis(argParser.SvnPath, argParser.FilterCommitFiles);

				CommitFile[] cf = ba.GetUnCommitChangedFiles();

                Log.Logger().Write(new MessageLogItem(string.Format(CultureInfo.InvariantCulture, Events.EndCheckBranch, DateTime.Now), TypeLogItem.Info));

                if (cf.Length > 0)
                {
                    foreach (CommitFile itemFile in cf)
                    {
                        Log.Logger().Write(new MessageLogItem(string.Format(CultureInfo.InvariantCulture, Consts.UnsupportedFile, itemFile.Location, itemFile.Status), TypeLogItem.Warning));
                    }

                    if (argParser.NotifierPath.Length > 0)
                    {
                        var pcfxml = SerializationHelper.XmlSerialization(cf);

                        Log.Logger().Write(new MessageLogItem(string.Format(CultureInfo.InvariantCulture, Events.StartNotify, argParser.NotifierPath), TypeLogItem.Info));

                        var bytes = Encoding.UTF8.GetBytes(pcfxml);
                        var base64EncodedData = Convert.ToBase64String(bytes);

                        Launcher lancher = new Launcher(argParser.NotifierPath, base64EncodedData);
                        lancher.Exec();
                    }
                }
                else
                {
                    Log.Logger().Write(new MessageLogItem(Consts.NoFiles, TypeLogItem.Info));
                }
			}
			catch (Exception ex)
            {
                Log.Logger().Write(new MessageLogItem(ex.Message, TypeLogItem.Error));
            }
            finally
            {
                Log.Logger().Write(new MessageLogItem(string.Format(CultureInfo.InvariantCulture, Events.EndProcess, DateTime.Now), TypeLogItem.Info));
                Log.Logger().Flush();
            }
            
            return 0;
        }

    }
}
