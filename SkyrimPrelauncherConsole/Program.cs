using System;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using SkyrimPrelauncherConsole.Configuration;

[assembly: InternalsVisibleTo("SkyrimPrelauncherTests")]
namespace SkyrimPrelauncherConsole
{
    internal class Program
    {
        private static string PathToLauncher = ConfigurationManager.AppSettings["PathToLauncher"];
        private static string WaitTimeString = ConfigurationManager.AppSettings["DelayInSeconds"];
        internal static ExitCode StatusCode = 0;
        
        
        public static int Main(string[] args)
        {
            var configuration = new SkyrimPrelauncherConfiguration();
        
            if (AppSettingsValidated())
            {
                if (int.TryParse(WaitTimeString, out int waitTimeSeconds))
                {
                    var waitTimeMilliseconds = ConvertToMilliseconds(waitTimeSeconds);
                    Thread.Sleep(waitTimeMilliseconds);
                }

                Process.Start(PathToLauncher);
            }

            return (int)StatusCode;
        }

        internal static int ConvertToMilliseconds(int waitTimeSeconds, bool ignoreWarning = false)
        {
            if (waitTimeSeconds > 30 &! ignoreWarning)
            {
                throw new Exception("30 seconds is a long time to wait for ENBSeries to be injected. \n If you are sure, launch the app from the command line with this parameter: '- ignoreWarning'.");
            }
            return waitTimeSeconds * 1000;
        }

        internal static SkyrimPrelauncherConfiguration AppSettingsValidated()
        {
            if (string.IsNullOrEmpty(PathToLauncher) || string.IsNullOrEmpty(WaitTimeString))
            {
                StatusCode = ExitCode.EmptyAppSettingParameter;
                return false;
            }

            return true;
        }
    }
}