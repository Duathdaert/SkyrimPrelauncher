using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SkyrimPrelauncherTests")]
namespace SkyrimPrelauncherConsole.Configuration
{
    internal interface ISkyrimPrelauncherConfiguration
    {
        string DelayInSeconds { get; }
        string PathToLauncher { get; }
    }
}