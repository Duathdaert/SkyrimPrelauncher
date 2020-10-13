using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SkyrimPrelauncherConsole;
using SkyrimPrelauncherConsole.Configuration;

namespace SkyrimPrelauncherTests
{
    [TestClass]
    public class Tests
    {
        private Mock<ISkyrimPrelauncherConfiguration>? mockConfiguration;

        [TestInitialize]
        private void Setup()
        {
            mockConfiguration = new Mock<ISkyrimPrelauncherConfiguration>();
            
        }
        
        
        [TestMethod]
        public void VerifyAppSettingsReturnsErrorCode1ForEmptyParams()
        {
            mockConfiguration?.SetupGet(x => x.DelayInSeconds).Returns(string.Empty);
            mockConfiguration?.SetupGet(x => x.PathToLauncher).Returns(string.Empty);
            var result = Program.VerifyAppSettings();
            
            Assert.AreEqual(1, result);
        }
    }
}