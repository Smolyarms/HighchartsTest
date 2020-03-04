using HWTAProj.SearchEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace HWTAProj
{
    [TestClass]
    public class TestSerch_Engine
    {
        [TestMethod]
        public void Google()
        {
            IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
            GooglePage page = new GooglePage(driver);
            page.GoToPage();
            System.Threading.Thread.Sleep(6000);
            page.Search("google");
            System.Threading.Thread.Sleep(6000);
            driver.Close();
        }
    }
}
