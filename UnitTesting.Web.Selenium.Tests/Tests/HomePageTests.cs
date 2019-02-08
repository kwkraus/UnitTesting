using UnitTesting.Web.Selenium.Framework.Pages;
using Xunit;

namespace UnitTesting.Web.Selenium.Tests.Tests
{
    public class HomePageTests : TestBase
    {
        [Fact]
        public void HomePage_Navigate_and_Verify()
        {
            HomePage.GoTo();

            Assert.True(HomePage.IsAt);
        }
    }
}
