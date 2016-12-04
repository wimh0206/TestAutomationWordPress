using TechTalk.SpecFlow;
using TestWordPressFramework.SeleniumHelper;
using TestAutomationWordPress.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAutomationWordPress.StepDefinitions
{
    [Binding]
    public class LoginFeaturesSteps
    {
        public  string username = null;
        public  string password = null;
        [Given(@"I am in Login page")]
        public void GivenIAmInLoginPage()
        {
        }
        [Given(@"I enter username '(.*)'")]
        public void GivenIEnterUsername(string username)
        {
            SeleniumHelper.EnterKey(LoginPageObjects.Username_Input, username);
            this.username = username;
        }

        [Given(@"I enter password '(.*)'")]
        public void GivenIEnterPassword(string password)
        {
            SeleniumHelper.EnterKey(LoginPageObjects.Password_Input, password);
            this.password = password;
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            SeleniumHelper.Click(LoginPageObjects.Login_Button);
        }

        [Then(@"My page displays successfully")]
        public void ThenMyPageDisplaysSuccessfully()
        {
            Assert.IsTrue(SeleniumHelper.GetText(AdminHomePage.Accoutadmin_bar).Contains(username));
        }

    }
}
