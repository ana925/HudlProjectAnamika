using HudlProjectAnamika.AutomationResources;
using HudlProjectAnamika.SetUpMethods;
using OpenQA.Selenium;

namespace HudlProjectAnamika.PageObjects
{
    public class LoginPage : BasePage
    {
        private ExplicitWait wait;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            wait = new ExplicitWait(driver);
        }

       //Login with given username and password

        public void Login(string email, string password)
        {
            emailField.Clear();
            emailField.SendKeys(email);

            passwordField.Clear();
            passwordField.SendKeys(password);

            loginBtn.Click();
        }

       //Remember me Checkbox

        public void RememberMe()
        {
            rememberMeCheckbox.Click();
        }

        //Retrieve the data 

        public Tuple<string, string> GetRememberedLogin()
        {
            return Tuple.Create(emailField.GetAttribute("value"), passwordField.GetAttribute("value"));
        }

       //Error message display after giving invalid credentials

        public string LoginError()
        {
            return errorDisplay.Text;
        }

        //Email Field
        IWebElement emailField => wait.FindElement(By.Id("email"));

        //Password Field
        IWebElement passwordField => wait.FindElement(By.Id("password"));

        //Log In Button
        IWebElement loginBtn => wait.FindElement(By.Id("logIn"));

        //Remember Me Checkbox
        IWebElement rememberMeCheckbox => wait.FindElement(By.XPath("//label[@data-qa-id='remember-me-checkbox-label']"));

        //Error Display
        IWebElement errorDisplay => wait.FindElement(By.XPath("//p[@data-qa-id='error-display']"));
    }
}
