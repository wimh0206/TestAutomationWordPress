using System;
using System.Configuration;
using TechTalk.SpecFlow;
using TestWordPressFramework.SeleniumHelper;
using TestAutomationWordPress.StepDefinitions;
using System.Threading;

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
            Console.WriteLine(ScenarioContext.Current.ScenarioInfo.Tags.ToString());
            Console.WriteLine(FeatureContext.Current.FeatureInfo.Title);
            SeleniumHelper.GoToUrl(ConfigurationManager.AppSettings["WebURL"]);
            if (!FeatureContext.Current.FeatureInfo.Title.Equals("LoginFeatures"))
                Helpers.ScenarioHelpers.Login();
        }
        [AfterScenario("addnewpost")]
        public void AfterScenarioAddNewPost()
        {
            //TODO: implement logic that has to run after executing each scenario
            // delete title has just created
            var mainhover = PageObjects.PostObjects.PostTitleText.Replace("<Get Title>", PostBlogSteps.title);
            var del = PageObjects.PostObjects.Trash.Replace("<Get Title>", PostBlogSteps.title);
            SeleniumHelper.HoverandClickMenu(mainhover,del);
            Thread.Sleep(3000);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            Factory.CloseSeleniumSession();
        }
       
    }
}