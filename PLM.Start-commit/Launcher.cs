using System.Diagnostics;

namespace PLM.Start_commit
{
	internal class Launcher
	{
		private readonly string _programm;
		private readonly string _arg;

		public Launcher(string programm, string arg)
		{
			_programm = programm;
			_arg = arg;
		}

		public int Exec()
		{
			using (var process = Process.Start(new ProcessStartInfo(_programm, _arg)))
			{
				if (process != null) return 0;
				return 1;
			}
		}
	}
}
