using System;
using TechTalk.SpecFlow;

namespace TestAutomationWordPress.StepDefinitions
{
    [Binding]
    public class LoginFeaturesSteps
    {
        [Given(@"I am in Login page")]
        public void GivenIAmInLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
