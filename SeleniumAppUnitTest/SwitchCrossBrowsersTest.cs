using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumAppUnitTest
{
    [TestClass]
    class SwitchCrossBrowsersTest
    {
        [TestMethod]
        public void SwitchBrowsers()
        {

            string ConfigDefUsername = ConfigurationManager.AppSettings["Username"].ToString();
            string ConfigDefPassword = ConfigurationManager.AppSettings["Password"].ToString();
            string ConfigDefQuestion = ConfigurationManager.AppSettings["Question"].ToString();
            string ConfigDefProjectPath = ConfigurationManager.AppSettings["ProjectPath"].ToString();
            string ConfigDefBrowser = ConfigurationManager.AppSettings["Browser"].ToString();
            string ConfigDefTestDate = ConfigurationManager.AppSettings["TestDate"].ToString();
            string ConfigDefTestName = ConfigurationManager.AppSettings["TestName"].ToString();

            string TestPath = @ConfigDefProjectPath + "\\Screenshots\\" + ConfigDefTestDate + "\\TestName-" + ConfigDefTestName;
            //string TestPath = @ConfigDefProjectPath + "\\Screenshots\\" + DateTime.Now.ToString("dd_MM_yyyy") + "\\TestName-" + ConfigDefTestName;


            IWebDriver driver = null;
            SwitchCrossBrowsers SI;

            switch (ConfigDefBrowser)
            {
                case "All":
                    Console.WriteLine("");
                    goto case "Chrome";

                case "Chrome":
                    ChromeOptions options = new ChromeOptions();  //Chrome Browser related to remove pop-up
                    options.AddArguments("disable-infobars");

                    driver = new ChromeDriver(options);  //Remove Break and Run all cases one after one
                    SI = new SwitchCrossBrowsers();
                    ConfigDefBrowser = "Chrome";
                    SI.BrowserInstances(driver, TestPath, ConfigDefBrowser, ConfigDefQuestion, ConfigDefUsername, ConfigDefPassword);
                    //break;
                    goto case "Firefox";

                case "Firefox":
                    driver = new FirefoxDriver();
                    SI = new SwitchCrossBrowsers();
                    ConfigDefBrowser = "Firefox";
                    SI.BrowserInstances(driver, TestPath, ConfigDefBrowser, ConfigDefQuestion, ConfigDefUsername, ConfigDefPassword);
                    //break;
                    goto case "ErrorImage";

                case "ErrorImage":
                    //   SI = new SwitchCrossBrowsersInstances();
                    //   SI.DirImageMisMatchInstance(TestPath);
                    break;

                default:
                    break; //Forward to image comparision

            }

        }
    }
}
