using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumAppUnitTest
{
    [TestClass]
    public class FirefoxLaunchTest
    {
        [TestMethod]
        public void GoogleSearch()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(4000);
            driver.Close();
        }
    }
}
