using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWordPressFramework.SeleniumHelper
{
    public class Factory
    {
        static IWebDriver driver = null;
        public static int timeout=1000;
        public static IWebDriver CreateSeleniumSession(String Browser)
        {
            Console.WriteLine("======================Create Session======");
            var folderdriver = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\driver\\";
            switch (Browser)
            {
                case "IE":
                    InternetExplorerOptions option = new InternetExplorerOptions();
                    option.IgnoreZoomLevel = true;
                    option.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    driver = new InternetExplorerDriver(folderdriver);
                    break;
                case "CH":
                    driver = new ChromeDriver(folderdriver);
                    break;
                default:
                    FirefoxProfile profile = new FirefoxProfile();
                    driver = new FirefoxDriver(profile);
                    break;
            }
            SeleniumHelper.Register(driver);
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan (0,0,timeout));
            driver.Manage().Window.Maximize();
          //  driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["webUrl"]);
            return driver;   
        }
        //close selenium session
        public static void CloseSeleniumSession()
        {
            driver.Quit();
        }
    }
}
