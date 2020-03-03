using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace HighchartsTest
{
    abstract class Page
    {
        protected Page (IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            PageFactory.InitElements(driver, this);
        }
        protected IWebDriver driver;
        public abstract string url { get; }
        public abstract void GoToPage();
        

    }
}
