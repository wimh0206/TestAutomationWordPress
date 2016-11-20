using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWordPressFramework.SeleniumHelper
{
    public class SeleniumHelper
    {
        public static IWebDriver driver = null;
        public static int timeOut = 1000;
        public static void Register(IWebDriver seleniumDriver)
        {
            driver = seleniumDriver;
        }
        //find Element
        public static IWebElement FindElement (String xpath)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            // return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            Console.WriteLine("Finding on: " + xpath);
            return wait.Until(drv => drv.FindElement(By.XPath(xpath)));
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
            FindElement(xpath).SendKeys(xpath);
            FindElement(xpath).SendKeys(Keys.Tab);
        }


    }
}
