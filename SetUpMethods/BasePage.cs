using System;
using OpenQA.Selenium;

namespace HudlProjectAnamika.SetUpMethods
{
    public class BasePage
    {
        protected IWebDriver Driver;     

            public BasePage(IWebDriver driver)
            {
                Driver = driver;
            }
    }
}


