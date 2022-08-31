using HudlProjectAnamika.SetUpMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HudlProjectAnamika.AutomationResources
    {
    public class ExplicitWait : BasePage
    {

        public WebDriverWait wait;

        public ExplicitWait(IWebDriver driver) : base(driver)
        {
            this.Driver = driver;
            TimeSpan timeout = TimeSpan.FromSeconds(30);
            this.wait = new WebDriverWait(driver, timeout);

            wait.Message = "wait timed out after 30 seconds";
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
        }

        //Wait till the element is enabled

        private void WaitUntilElementIsEnabled(By locator)
        {
            Func<IWebDriver, bool> condition =
                d =>
                {
                    IWebElement e = d.FindElement(locator);
                    return e.Enabled;
                };

            wait.Until(condition);
        }

        //to wait until element is displayed

        private void WaitUntilElementIsDisplayed(By locator)
        {
            wait.Until(d =>
            {
                IWebElement e = d.FindElement(locator);
                return e.Displayed;
            });
        }

        //to find the element

        public IWebElement FindEnabledElement(By locator)
        {
            WaitUntilElementIsEnabled(locator);
            IWebElement element = Driver.FindElement(locator);
            return element;
        }

        //to find the element

        public IWebElement FindElement(By locator)
        {
            WaitUntilElementIsDisplayed(locator);
            IWebElement element = Driver.FindElement(locator);
            return element;
        }
    }
}