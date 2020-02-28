using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace HighchartsTest
{
    class HighMapsPage : BaseChartsPage
    {
        public override string url => "https://www.highcharts.com/maps/demo/all-maps#countries/ua/ua-all";
        public HighMapsPage(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point")]
        private IList<IWebElement> mapUkraine;
        
        public IList<IWebElement> GetMapChart()
        {
            return mapUkraine;
        }
    }
}
