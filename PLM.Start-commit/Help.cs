using System;

namespace PLM.Start_commit
{
    internal class Help
	{
		public static void Show()
		{
            Console.WriteLine();
            Console.WriteLine(Consts.HelpCommandArg + "\r\n\r\n" + Consts.HelpCmdArgDescr);
		}
	}
}
