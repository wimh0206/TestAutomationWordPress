using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TestWordPressFramework.SeleniumHelper
{
    public class SeleniumHelper
    {
        public static IWebDriver driver { get; set; }
        public static int timeOut = 10;
        public static void Register(IWebDriver seleniumDriver)
        {
            driver = seleniumDriver;
        }
        //find Element
        public static IWebElement FindElement(String xpath)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            // return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            Console.WriteLine("Finding on: " + xpath);
            try
            {
                return wait.Until(drv => drv.FindElement(By.XPath(xpath)));
            } catch (Exception ex)
            {
                Console.WriteLine("can not find element " + ex.Message);
                return null;
            }
        }
        //Click Element
        public static void Click(String xpath)
        {
            Console.WriteLine("Click on: {0}", xpath);
            FindElement(xpath).Click();
        }

        public static void EnterKey(String xpath, String value)
        {
            Console.WriteLine("Enter value: {0} into {1}", xpath, value);
            FindElement(xpath).Clear();
            FindElement(xpath).SendKeys(value);
            FindElement(xpath).SendKeys(Keys.Tab);
        }

        public static void GoToUrl(String url)
        {
            Console.WriteLine("Go to Page: " + url);
            driver.Navigate().GoToUrl(url);
        }

        public static string GetText(String xpath)
        {
            return FindElement(xpath).Text.ToString();
        }
        public static void HoverandClickMenu(string menuxpath, string submenuxpath)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(FindElement(menuxpath)).Perform();
            Click(submenuxpath);
           
        }
        public static void EnterValueInFrame(string framename, string value)
        {
           // driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(0);
            var element = driver.SwitchTo().ActiveElement();
            element.SendKeys(value);
            Thread.Sleep(1000);
            driver.SwitchTo().DefaultContent();
        }
        public static bool CheckElementDisplay(String xpath)
        {
            return FindElement(xpath).Displayed;
        }
        public static string GetAttributeInput (string xpathinput)
        {
            Console.WriteLine("Get Value of input", xpathinput);
            return FindElement(xpathinput).GetAttribute("value");
        }
        
    }
}
