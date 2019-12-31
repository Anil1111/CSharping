using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAppUnitTest
{


    [TestClass]
    public class ChromeLaunchTest
    {
        [TestMethod]
        public void GoogleSearch()
        {
            IWebDriver driver = null;

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            driver = new ChromeDriver(options);

            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com/");
            Thread.Sleep(4000);
            driver.Quit();
        }
    }

    
}
