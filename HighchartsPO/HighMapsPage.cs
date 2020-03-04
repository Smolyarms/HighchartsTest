using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace HWTAProj
{
    class HighMapsPage : BaseChartsPage
    {
        [FindsBy(How = How.CssSelector, Using = "path.highcharts-point")]
        private IList<IWebElement> mapLabels;

        public override string Url => "https://www.highcharts.com/maps/demo/all-maps#countries/ua/ua-all";
        public HighMapsPage(IWebDriver driver) : base(driver)
        {
        }
        public IList<IWebElement> GetMapChart()
        {
            return mapLabels;
        }
    }
}
