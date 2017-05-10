using Legacy.EventLog.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.EventLog.Test
{
    [TestClass]
    public class FileLogServiceTests
    {
        private FileLogService _sut;

        [TestInitialize]
        public void TestInitialize()
        {
            _sut = new FileLogService();    
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _sut = null;
        }

        [TestMethod]
        public void AddEntry_ShouldIncreaseCount()
        {
            Assert.AreEqual(0, _sut.EntryCounter);
        }
    }
}
