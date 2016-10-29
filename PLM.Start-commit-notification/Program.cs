using PLM.Start_commit_notification.BO;
using PLM.Start_commit_notification.Form;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PLM.Start_commit_notification
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
			if (args.Length > 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.ThreadException += delegate (object sender, ThreadExceptionEventArgs t) { MessageBox.Show(t.Exception.Message, Consts.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error); };

                var mainForm = new FmViewFile (args);
                Application.Run(mainForm);
            }
        }
    }
}
