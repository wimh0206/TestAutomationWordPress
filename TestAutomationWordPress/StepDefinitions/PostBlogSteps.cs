using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using TestWordPressFramework.SeleniumHelper;

namespace TestAutomationWordPress.StepDefinitions
{
    [Binding]
    public class PostBlogSteps
    {
        public static string title = null;
        [Given(@"I am in All Post Page")]
        public void GivenIAmInAllPostPage()
        {
            SeleniumHelper.HoverandClickMenu(PageObjects.MenuObjects.Posts, PageObjects.MenuObjects.Posts_AllPost);
        }
        
        [When(@"I click Add New Button")]
        public void WhenIClickAddNewButton()
        {
            SeleniumHelper.Click(PageObjects.MenuObjects.Posts_AddNew);
        }
        
        [When(@"I enter title")]
        public void WhenIEnterTitle()
        {
            title = "Title " + DateTime.Now.ToString("dd-MM-yyyy");
            SeleniumHelper.EnterKey(PageObjects.AddNewObjects.Title, title);
        }

        [When(@"I am in All Post Page")]
        public void WhenIAmInAllPostPage()
        {
            SeleniumHelper.Click(PageObjects.MenuObjects.Posts_AllPost);
        }

        [Then(@"the Add New Post Page appears")]
        public void ThenTheAddNewPostPageAppears()
        {
            Assert.IsTrue(SeleniumHelper.CheckElementDisplay(PageObjects.AddNewObjects.AddNewPostPage),"Not found");
        }
        
        [Then(@"Permanent Link appear")]
        public void ThenPermanentLinkAppear()
        {
            SeleniumHelper.FindElement(PageObjects.AddNewObjects.PermanentLink);
            var actualLink=SeleniumHelper.GetText(PageObjects.AddNewObjects.PermanentLink);
            var titlelink = title.Trim().ToLower().Replace(" ", "-");
            var expectedLink= ConfigurationManager.AppSettings["WebIndexURL"].ToString() + "/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Date.ToString("dd") + "/" + titlelink + "/";
            Assert.AreEqual(expectedLink, actualLink);

        }
        
        [When(@"I enter content")]
        public void WhenIEnterContent()
        {
            SeleniumHelper.EnterValueInFrame(PageObjects.AddNewObjects.Content, "Hi, this is body " + title);
        }
        
        [When(@"I click Publish")]
        public void ThenIClickPublish()
        {
            SeleniumHelper.Click(PageObjects.AddNewObjects.PublishButton);
        }

        [Then(@"Edit Post Page appear")]
        public void ThenEditPostPageAppear()
        {
            Assert.IsTrue(SeleniumHelper.CheckElementDisplay(PageObjects.AddNewObjects.EditPostPage),"not found element");
            Assert.AreEqual(SeleniumHelper.GetAttributeInput(PageObjects.AddNewObjects.Title).ToString(),title);
        }

        [Then(@"new Post display in grid")]
        public void ThenNewPostDisplayInGrid()
        {
            var element= PageObjects.PostObjects.PostTitleText.Replace("<Get Title>", title);
          //  var element = ".//*[text()='" + title + "']";
            Assert.IsTrue(SeleniumHelper.CheckElementDisplay(element),"not found element");
        }
    }
}
