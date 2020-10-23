using IHSMarkit_PCM.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace IHSMarkit_PCM.StepDefinitions
{
    [Binding]
    public class Test1Steps
    {
        Test1Page test1Page;
        public Test1Steps()
        {
            test1Page = new Test1Page();
        }

        [Given(@"a user navigate to ""(.*)""")]
        public void GivenAUserNavigateTo(string url)
        {
            test1Page.NavigateTowebsite(url);
        }

        [Given(@"a user click on run button")]
        public void GivenAUserClickOnRunButton()
        {
            test1Page.ClickRunButton();
        }

        [Then(@"the text ""(.*)"" is displayed in the Output Window")]
        public void ThenTheTextIsDisplayedInTheOutputWindow(string WindowOutput)
        {
            

            Assert.IsTrue(test1Page.WindowOutputIsDisplayed(), "Hello World");

        }
    }
}

