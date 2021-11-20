using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework
{
    public class Selenium
    {
        private static IWebDriver _driver;
        private static string _driverPath => TestContext.CurrentContext.WorkDirectory.Replace("bin\\Debug", "chromeDriver");
        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new ChromeDriver(_driverPath);
                }
                return _driver;
            }
        }
    }
}
