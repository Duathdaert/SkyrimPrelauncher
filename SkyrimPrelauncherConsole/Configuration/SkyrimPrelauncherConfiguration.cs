using System.Configuration;

namespace SkyrimPrelauncherConsole.Configuration
{
    internal class SkyrimPrelauncherConfiguration : ISkyrimPrelauncherConfiguration
    {
        public string DelayInSeconds
        {
            get
            {
                return ConfigurationManager.AppSettings["DelayInSeconds"];
            }
        }

        public string PathToLauncher
        {
            get
            {
                return ConfigurationManager.AppSettings["PathToLauncher"];
            }
        }
    }
}