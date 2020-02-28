using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace HighchartsTest
{
    abstract class BaseChartsPage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "g.highcharts-tooltip")]
        protected IWebElement tooltip;
        [FindsBy(How = How.CssSelector, Using = "div.sidebar-eq.demo")]
        private IWebElement chartsArea;
        public BaseChartsPage(IWebDriver driver) : base(driver)
        {
        }
        public void HoverTo(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Build().Perform();
        }
        public string GetTooltipText(IWebElement element)
        {
            HoverTo(element);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            wait.Until(driver => tooltip.Displayed);
            return tooltip.Text;
        }
        public void HoverToChartsArea()
        {
            HoverTo(chartsArea);
        }

    }
}
