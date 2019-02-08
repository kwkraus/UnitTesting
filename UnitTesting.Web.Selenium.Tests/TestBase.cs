using System;
using System.Configuration;
using UnitTesting.Web.Selenium.Framework;

namespace UnitTesting.Web.Selenium.Tests
{
    public abstract class TestBase : IDisposable
    {
        protected TestBase()
        {
            Driver.Initialize(
                ConfigurationManager.AppSettings["TargetBrowser"].ToString(),
                bool.Parse(ConfigurationManager.AppSettings["isPrivateMode"].ToString()),
                bool.Parse(ConfigurationManager.AppSettings["isHeadless"].ToString()));
            Driver.BaseUrl = ConfigurationManager.AppSettings["BaseUrl"].ToString();
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
