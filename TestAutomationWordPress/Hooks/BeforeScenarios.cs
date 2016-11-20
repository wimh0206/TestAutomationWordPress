using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestWordPressFramework.SeleniumHelper;
namespace TestAutomationWordPress.Hooks
{
    [Binding]
    public sealed class BeforeScenarios
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            Factory.CreateSeleniumSession(ConfigurationManager.AppSettings["Browser"]);
            SeleniumHelper.GoToUrl(ConfigurationManager.AppSettings["WebURL"]);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            Factory.CloseSeleniumSession();
        }
    }
}