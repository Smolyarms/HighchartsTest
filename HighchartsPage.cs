using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace HighchartsTest
{
    class HighchartsPage
    {
        protected IWebDriver driver;
        
        public HighchartsPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-0")]
        private IList<IWebElement> googleChart;

        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-1")]
        private IList<IWebElement> revenueChart;

        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-2")]
        private IList<IWebElement> employeesChart;

        [FindsBy(How = How.CssSelector, Using = "g.highcharts-tooltip")]
        private IWebElement tooltip;

        [FindsBy(How = How.CssSelector, Using = "button[aria-label = 'Toggle visibility of Google search for highcharts']")]
        private IWebElement buttonGoogleChart;

        [FindsBy(How = How.CssSelector, Using = "button[aria-label = 'Toggle visibility of Revenue']")]
        private IWebElement buttonRevenueChart;

        [FindsBy(How = How.CssSelector, Using = "button[aria-label = 'Toggle visibility of Highsoft employees']")]
        private IWebElement buttonEmployeesChart;

        [FindsBy(How = How.CssSelector, Using = "g.highcharts-plot-bands-0")]
        private IWebElement chartsArea;

        [FindsBy(How =How.CssSelector, Using = ".highcharts-flags-series.highcharts-tracker ")]
        private IList<IWebElement> flags;

        public HighchartsPage GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.highcharts.com/demo/combo-timeline");
            return new HighchartsPage(driver);
        }

        public IList<IWebElement> GetGoogleChart()
        {
            return googleChart;
        }
        public IList<IWebElement> GetRevenueChart()
        {
            return revenueChart;
        }
        public IList<IWebElement> GetEmployeesChart()
        {
            return employeesChart;
        }
        
        public string GetTooltipText(IWebElement element)
        {
            //TODO: Add waiter of tooltip
            HoverTo(element);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            wait.Until(driver => tooltip.Displayed);
            return tooltip.Text;
        }

        //public void TurnOnChart(IWebElement chartButton)
        //{
        //    var attValue = chartButton.GetAttribute("aria - pressed");
        //    if (attValue == "true")
        //    {
        //        chartButton.Click();
        //    }
        //}

        //public void TurnOffChart()
        //{
        //    buttonEmployeesChart.Click();
        //    buttonRevenueChart.Click();
        //}
        public void HoverTo(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Build().Perform();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //String mouseOverScript = "if(document.createEvent){var evObj = document.createEvent('MouseEvents');evObj.initEvent('mouseover',true, false); arguments[0].dispatchEvent(evObj);} else if(document.createEventObject) { arguments[0].fireEvent('onmouseover');}";
            //js.ExecuteScript(mouseOverScript, element);
        }    
        public void HoverToChartsArea()
        {
            HoverTo(chartsArea);
        }
        public void HideFlags()
        {
            foreach (IWebElement i  in flags)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.visibility='hidden'", i);
            }
        }
    }
}
