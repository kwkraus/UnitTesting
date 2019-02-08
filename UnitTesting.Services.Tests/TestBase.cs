using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Services.Tests
{
    public class TestBase
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestCleanup]
        public void Cleanup()
        {

        }

        public TestContext TestContext { get; set; }
    }
}
