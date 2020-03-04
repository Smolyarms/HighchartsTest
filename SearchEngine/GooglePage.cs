using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWTAProj.SearchEngine
{
    class GooglePage : SearchEnginePage
    {
        public override string Url => "https://www.google.com/";
        protected override IWebElement SearchField => driver.FindElement(By.CssSelector("input.gsfi"));
        protected override IList<IWebElement> SearchResult => driver.FindElements(By.CssSelector("div.srg div.g"));
        protected override IWebElement BtnNext => driver.FindElement(By.CssSelector("a#pnnext.pn"));
        protected override IWebElement CurrentPage => driver.FindElement(By.CssSelector("td.cur"));

        public void Search(string text)
        {
            SearchField.SendKeys(text);
            SearchField.Submit();
        }

        public GooglePage(IWebDriver driver) : base(driver)
        {
        }
    }
}
