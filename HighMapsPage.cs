using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace HighchartsTest
{
    class HighMapsPage : BaseChartsPage
    {
        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point")]
        private IList<IWebElement> mapLabels;

        public override string url => "https://www.highcharts.com/maps/demo/all-maps#countries/ua/ua-all";
        public HighMapsPage(IWebDriver driver) : base(driver)
        {
        }
        public IList<IWebElement> GetMapChart()
        {
            return mapLabels;
        }
    }
}
