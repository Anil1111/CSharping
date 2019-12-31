using System.Threading;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumAppUnitTest
{
    class SwitchCrossBrowsers
    {
        public void BrowserInstances(IWebDriver driver, string TestPath, string ConfigDefBrowser, string ConfigDefQuestion, string ConfigDefUsername, string ConfigDefPassword)
        {
            string ScreenshotId;
            string ScreenshotPath;
            DirectoryInfo di;

            By UsernameTxt = By.XPath("//*[@id='page-container']/div/div[1]/form/fieldset/div[1]/input");
            By PasswordTxt = By.XPath("//*[@id='page-container']/div/div[1]/form/fieldset/div[2]/input");
            By LoginBtn = By.XPath("//*[@id='page-container']/div/div[1]/form/div[2]/button");
            By Profilebtn = By.XPath("//*[@id='user-dropdown-toggle']");
            By LogoutBtn = By.XPath("//*[@id='signout-button']/button");

            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com/");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input")).SendKeys("8555814857");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[3]/center/input[1]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[2]/div/div[1]/input")).Clear();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[2]/div/div[1]/input")).SendKeys(ConfigDefQuestion);
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[2]/button")).Click();
            Thread.Sleep(3000);
            ScreenshotId = "1";
            ScreenshotPath = TestPath + "\\ScreenshotId-" + ScreenshotId;
            //ScreenshotPath = TestPath + "\\ScreenshotId-" + (++ScreenshotId).ToString();
            di = Directory.CreateDirectory(ScreenshotPath);
            driver.TakeScreenshot().SaveAsFile(@ScreenshotPath + "\\" + ConfigDefBrowser + ".png", ScreenshotImageFormat.Png);

            Thread.Sleep(1000);

        }
    }
}
