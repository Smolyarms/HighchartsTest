using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace HighchartsTest
{
    class HighchartsPage : BaseChartsPage
    {
        public override string url => "https://www.highcharts.com/demo/combo-timeline";
        public HighchartsPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-0")]
        private IList<IWebElement> googleChart;

        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-1")]
        private IList<IWebElement> revenueChart;

        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-2")]
        private IList<IWebElement> employeesChart;
        //[FindsBy(How = How.CssSelector, Using = "button[aria-label = 'Toggle visibility of Google search for highcharts']")]
        //private IWebElement buttonGoogleChart;

        //[FindsBy(How = How.CssSelector, Using = "button[aria-label = 'Toggle visibility of Revenue']")]
        //private IWebElement buttonRevenueChart;

        //[FindsBy(How = How.CssSelector, Using = "button[aria-label = 'Toggle visibility of Highsoft employees']")]
        //private IWebElement buttonEmployeesChart;
        
        //g.highcharts-plot-bands-0
        [FindsBy(How =How.CssSelector, Using = ".highcharts-flags-series.highcharts-tracker ")]
        private IList<IWebElement> flags;

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
        
        public void HideFlags()
        {
            foreach (IWebElement i  in flags)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.visibility='hidden'", i);
            }
        }
    }
}
