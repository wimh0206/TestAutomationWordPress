using System.Configuration;
using TestWordPressFramework.SeleniumHelper;

namespace TestAutomationWordPress.Hooks.Helpers
{
    public class ScenarioHelpers
    {
        private static string username = ConfigurationManager.AppSettings["UserName"];
        private static string password = ConfigurationManager.AppSettings["PassWord"];
        public static void Login()
        {
            SeleniumHelper.EnterKey(PageObjects.LoginPageObjects.Username_Input, username);
            SeleniumHelper.EnterKey(PageObjects.LoginPageObjects.Password_Input, password);
            SeleniumHelper.Click(PageObjects.LoginPageObjects.Login_Button);
        }

    }
}
