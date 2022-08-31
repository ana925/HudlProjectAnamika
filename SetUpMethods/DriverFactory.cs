using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
namespace HudlProjectAnamika.SetUpMethods
{
    public class DriverFactory
    {
      //to get the browser from the browser type file
        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                default:
                    throw new ArgumentOutOfRangeException("No such browser exists");
            }
        }

      //To retrieve the chrome driver from its location

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }
    }
}

