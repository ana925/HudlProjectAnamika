using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

using OpenQA.Selenium.Chrome;

namespace HudlProjectAnamika.SetUpMethods
{

    public class Test
    {
        public IWebDriver driver { get; private set; }

        [SetUp]
        public void SetupBeforeEveryTestMethod()
        {
            //var factory = new DriverFactory();
            //driver = factory.Create(BrowserType.Chrome);

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }     
        
       //This method closes the webdriver after every test       

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}