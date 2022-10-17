using Serilog;
using System.IO;

namespace MESWinForms.Services
{
    public class Logger
    {
        const string LOG_FILE = "MES.log";

        public Logger()
        {
            if (File.Exists(LOG_FILE))
                File.Delete(LOG_FILE);

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(LOG_FILE)
                .CreateLogger();
        }

        public void Info(string message) 
        {
            Log.Information(message);
        }

        public void Error(string message)
        {
            Log.Error(message);
        }
    }
}
