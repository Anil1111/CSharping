using System.Threading;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Interactions;

namespace SeleniumAppUnitTest
{
    [TestClass]
   public class SeleniumFeatures
    {
        [TestMethod]
        public void TextToGoogleSearch()
        {
            IWebDriver driver = null;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            driver = new ChromeDriver(options);
            Thread.Sleep(1000);

            driver.Manage().Window.Size = new System.Drawing.Size(1280, 916);
            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            driver.Navigate().GoToUrl("https://google.com/");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[5]/form/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys("5132787858");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[3]/center/input[1]")).Click();
            Thread.Sleep(3000);
            DirectoryInfo di = Directory.CreateDirectory(@"A:\Repos\CSharp\CSharping\SeleniumAppUnitTest\TestResults");
            Thread.Sleep(1000);
            driver.TakeScreenshot().SaveAsFile(@"A:\Repos\CSharp\CSharping\SeleniumAppUnitTest\TestResults\SearchResult1" + ".png", ScreenshotImageFormat.Png);
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div[4]/form/div[2]/div[1]/div[2]/div/div[2]/input")).Clear();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[4]/form/div[2]/div[1]/div[2]/div/div[2]/input")).SendKeys("Where is Charminar?");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[2]/button")).Click();
            Thread.Sleep(3000);
            DirectoryInfo di2 = Directory.CreateDirectory(@"A:\Repos\CSharp\CSharping\SeleniumAppUnitTest\TestResults");
            Thread.Sleep(1000);
            driver.TakeScreenshot().SaveAsFile(@"A:\Repos\CSharp\CSharping\SeleniumAppUnitTest\TestResults\SearchResult2" + ".png", ScreenshotImageFormat.Png);
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div[4]/form/div[2]/div[1]/div[2]/div/div[2]/input")).Clear();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[4]/form/div[2]/div[1]/div[2]/div/div[2]/input")).SendKeys("Who is Pre");
            Thread.Sleep(3000);

            Actions actions = new Actions(driver);
            Thread.Sleep(2000);
            actions.SendKeys(Keys.Backspace);
            Thread.Sleep(2000);
            actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control);

            //actions.MoveToElement(element);
            //Thread.Sleep(2000);
            //actions.SendKeys(Keys.ArrowDown);
            //Thread.Sleep(2000);
            //actions.SendKeys(Keys.ArrowDown);
            //Thread.Sleep(2000);
            //actions.SendKeys(Keys.Enter).Build().Perform();
            //Thread.Sleep(2000);
            //actions.SendKeys(Keys.Tab).Build().Perform();
            //Thread.Sleep(2000);
            //actions.SendKeys(Keys.Tab).Build().Perform();
            //Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[2]/button")).Click();
            Thread.Sleep(3000);
            DirectoryInfo di3 = Directory.CreateDirectory(@"A:\Repos\CSharp\CSharping\SeleniumAppUnitTest\TestResults");
            Thread.Sleep(1000);
            driver.TakeScreenshot().SaveAsFile(@"A:\Repos\CSharp\CSharping\SeleniumAppUnitTest\TestResults\SearchResult3" + ".png", ScreenshotImageFormat.Png);
            Thread.Sleep(4000);


            driver.Quit();
        }
    }
}
