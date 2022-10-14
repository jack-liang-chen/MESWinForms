using MESWinForms.Services;
using System;
using System.Windows.Forms;

namespace MESWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AppEngine.Initialize();
            AppEngine.RunStartupTasks();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(AppEngine.Resolve<MainForm>());

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            AppEngine.Resolve<Logger>().Error(e.ToString());
        }
    }
}
