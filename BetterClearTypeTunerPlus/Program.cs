using System;
using System.Threading;
using System.Windows.Forms;

namespace BetterClearTypeTunerPlus
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.OleRequired();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			using (var mutex = new Mutex(false, "BetterClearTypeTunerPlus_Unique_Mutex_Name"))
			{
				if (!mutex.WaitOne(0, false))
				{
					MessageBox.Show("Another instance of Better ClearType Tuner Plus is already running.", "Better ClearType Tuner Plus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				using (var mainForm = new MainForm())
				using (var appContext = new ApplicationContext(mainForm))
				{
					Application.Run(appContext);
                }
            }
        }
	}
}
