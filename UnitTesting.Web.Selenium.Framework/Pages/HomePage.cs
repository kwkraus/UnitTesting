using OpenQA.Selenium;

namespace UnitTesting.Web.Selenium.Framework.Pages
{
    public class HomePage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl($"{Driver.BaseUrl}/");
        }

        public static bool IsAt
        {
            get
            {
                var requestBtns = Driver.Instance.FindElements(By.Id("myCarousel"));

                if (requestBtns.Count > 0)
                {
                    return true;
                }
                else
                {
                    //Helper.TakeScreenShot(Driver.Instance, $"{nameof(HomePage)}-{nameof(IsAt)}");
                    return false;
                }
            }
        }
    }
}
