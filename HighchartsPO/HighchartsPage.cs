using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace HWTAProj
{
    class HighchartsPage : BaseChartsPage
    {
        public override string Url => "https://www.highcharts.com/demo/combo-timeline";
        public HighchartsPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-0")]
        private IList<IWebElement> googleChart;

        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-1")]
        private IList<IWebElement> revenueChart;

        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point.highcharts-color-2")]
        private IList<IWebElement> employeesChart;

        [FindsBy(How =How.CssSelector, Using = ".highcharts-flags-series.highcharts-tracker")]
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
        public void HideFlags()
        {
            foreach (IWebElement i  in flags)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.visibility='hidden'", i);
            }
        }

    }
}
