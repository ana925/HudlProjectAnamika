using HudlProjectAnamika.AutomationResources;
using HudlProjectAnamika.SetUpMethods;
using OpenQA.Selenium;

namespace HudlProjectAnamika.PageObjects
{
    public class HomePage : BasePage
    {
        private ExplicitWait wait;

        public HomePage(IWebDriver driver) : base(driver)
        {
            wait = new ExplicitWait(Driver);
        }

       //Navigate to the login page 

        public LoginPage GoTo()
        {
            Driver.Navigate().GoToUrl("https://www.hudl.com/login");
            return new LoginPage(Driver);
        }

        //get the current url

        public string GetCurrentURL()
        {
            wait.FindElement(By.XPath("//input[@title='Search']"));
            return Driver.Url;
        }
        //Logout

        public void Logout()
        {
            userMenu.Click();
            logoutButton.Click();
        }

        public void Login()
        {
            loginButton.Click();
        }
        //IWebElements

        //User Menu
        public IWebElement userMenu => wait.FindElement(By.ClassName("hui-globalusermenu"));

        //Logout Button
        public IWebElement logoutButton => wait.FindElement(By.XPath("//a[@data-qa-id='webnav-usermenu-logout']"));

        //Login Button
        public IWebElement loginButton => wait.FindElement(By.XPath("//a[@data-qa-id='login']"));
    }
}
