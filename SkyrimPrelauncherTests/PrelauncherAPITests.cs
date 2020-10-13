using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkyrimPrelauncherAPI;

namespace SkyrimPrelauncherTests
{
    [TestClass]
    public class PrelauncherAPITests
    {
        [TestMethod]
        public void PrelauncherWaitsForSpecifiedTime()
        {
            var sw = new Stopwatch();
            var timeToWait = 100;
            
            sw.Start();
            Prelauncher.LaunchExe(delayInMilliseconds: timeToWait);
            sw.Stop();
            
            Assert.IsTrue(sw.ElapsedMilliseconds > timeToWait);
        }
    }
}