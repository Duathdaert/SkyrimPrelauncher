using System;
using System.Threading;

namespace SkyrimPrelauncherAPI
{
    public static class Prelauncher
    {
        public static void LaunchExe(int delayInMilliseconds)
        {
            Thread.Sleep(delayInMilliseconds);
        }
    }
}