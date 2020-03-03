using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace HighchartsTest
{
    abstract class BaseChartsPage : Page
    {
        //TODO:File.WriteAllLines("GoogleChartTest.txt", result.Select(x => string.Join(",", x)));
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
            return tooltip.Text;
            //if (IsElementPresent(tooltip))
            //{
            //    return tooltip.Text;
            //}
            //else
            //{
            //    HoverTo(element);
            //    return tooltip.Text;
            //}
        }
        public void HoverToChartsArea()
        {
            HoverTo(chartsArea);
        }
        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        //private bool IsElementPresent(IWebElement element)
        //{
        //    try
        //    {
        //        if (element.Displayed)
        //        {
        //        }
        //        return true;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false;
        //    }
        //}


        
    }
}
