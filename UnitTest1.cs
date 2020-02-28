using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace HighchartsTest
{
    [TestClass]
    public class Charts_Test
    {
        private static IWebDriver driver;
        
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            HighchartsPage chartsPage = new HighchartsPage(driver);
            chartsPage.GoToPage();
            chartsPage.HoverToChartsArea();
            chartsPage.HideFlags();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Close();
        }
        [TestMethod]
        public void GoogleChartTest()
        {
            HighchartsPage chartsPage = new HighchartsPage(driver);
            IList<IWebElement> currentChart = chartsPage.GetGoogleChart();
            List<string> result = new List<string>();
            foreach (IWebElement i in currentChart)
            {
                string toolTipText = chartsPage.GetTooltipText(i);
                result.Add(toolTipText);
            }
            //TODO: Assert
        }
        [TestMethod]
        public void RevenueChartTest()
        {
            HighchartsPage chartsPage = new HighchartsPage(driver);
            IList<IWebElement> currentChart = chartsPage.GetRevenueChart();
            List<string> result = new List<string>();
            foreach (IWebElement i in currentChart)
            {
                string toolTipText = chartsPage.GetTooltipText(i);
                result.Add(toolTipText);
            }
            //TODO: Assert
        }
        [TestMethod]
        public void EmployeesChartTest()
        {
            HighchartsPage chartsPage = new HighchartsPage(driver);
            IList<IWebElement> currentChart = chartsPage.GetEmployeesChart();
            List<string> result = new List<string>();
            foreach (IWebElement i in currentChart)
            {
                string toolTipText = chartsPage.GetTooltipText(i);
                result.Add(toolTipText);
            }
            //TODO: Assert
        }
       
    }

    [TestClass]
    public class MapCharts_Test
    {
        [TestMethod]
        public void MapChartTest()
        {
            IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
            HighMapsPage mapPage = new HighMapsPage(driver);
            mapPage.GoToPage();
            mapPage.HoverToChartsArea();
            IList<IWebElement> currentChart = mapPage.GetMapChart();
            List<string> result = new List<string>();
            foreach (IWebElement i in currentChart)
            {
                string toolTipText = mapPage.GetTooltipText(i);
                result.Add(toolTipText);
            }
            //TODO: Assert
            driver.Close();
        }
    }
}
