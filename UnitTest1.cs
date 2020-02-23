using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace HighchartsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
                        
            HighchartsPage chartsPage = new HighchartsPage(driver);
            chartsPage.GoToPage();
            chartsPage.TurnOffChart();

            IList<IWebElement> googleChart = chartsPage.GetGoogleChart();
            List<string> result = new List<string>();
            foreach (IWebElement i in googleChart)
            {
                chartsPage.HoverTo(i);
                //var toolTipText = chartsPage.GetTooltipText();
                //result.Add(toolTipText);
            }

            driver.Close();
            
        }
    }
}
