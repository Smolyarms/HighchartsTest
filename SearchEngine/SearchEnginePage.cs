using OpenQA.Selenium;
using System.Collections.Generic;

namespace HWTAProj.SearchEngine
{
    abstract class SearchEnginePage : Page
    {
        public SearchEnginePage(IWebDriver driver) : base(driver)
        {
        }
        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(Url);
        }
        protected abstract IWebElement SearchField { get; }
        protected abstract IList<IWebElement> SearchResult { get; }
        protected abstract IWebElement BtnNext { get; }
        protected abstract IWebElement CurrentPage { get; }

    }
}
