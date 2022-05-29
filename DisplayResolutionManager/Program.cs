using System;
using System.Windows.Forms;
using CommonWinForms;

namespace DisplayResolutionManager
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			UIHelper.InRuntime = true;
			UIHelper.SetUnhandledExceptionSafe();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
