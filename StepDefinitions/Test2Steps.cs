using IHSMarkit_PCM.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace IHSMarkit_PCM.StepDefinitions
{
    [Binding]
    public class Test2Steps
    {
        Test2Page test2Page;
        public Test2Steps()
        {
            test2Page = new Test2Page();
        }

        [When(@"a user enter package name ""(.*)""")]
        public void WhenAUserEnterPackageName(string nunit)
        {
            test2Page.EnterPackageName(nunit);
        }

        [When(@"a user select version ""(.*)""")]
        public void WhenAUserSelectVersion(string version)
        {
            test2Page.ClickVersion();
        }

        [When(@"a user click on share button")]
        public void WhenAUserClickOnShareButton()
        {
            test2Page.ClickShare();
        }

        [When(@"a user click back button on Options panel to hide this panel")]
        public void WhenAUserClickBackButtonOnOptionsPanelToHideThisPanel()
        {
            test2Page.ClickSidebar();
        }

        [When(@"a user click on save button")]
        public void WhenAUserClickOnSaveButton()
        {
            test2Page.ClickSaveBtn();
        }

        [When(@"a user click on getting started button")]
        public void WhenAUserClickOnGettingStartedButton()
        {
            test2Page.ClickGetingStarted();
        }

        [Then(@"""(.*)"" Nuget Package is added Sucessfully")]
        public void ThenNugetPackageIsAddedSucessfully(string p0)
        {
            Assert.IsTrue(test2Page.NunitPackageIsDisplayed(), "NUnit");
        }


        [Then(@"the share link starts with ""“https://dotnetfiddle\.net/”")]
        public void ThenTheShareLinkStartsWithHttpsDotnetfiddle_Net()
        {
            test2Page.GetShareLink().Contains("https://dotnetfiddle.net/");
        }

        [Then(@"the Options panel is hidden")]
        public void ThenTheOptionsPanelIsHidden()
        {
            Assert.IsFalse(test2Page.OptionPanelIsDisplayed());
        }

        [Then(@"the “Log In” window should appear")]
        public void ThenTheLogInWindowShouldAppear()
        {
            Assert.IsTrue(test2Page.LogInWindowIsDisplayed());
        }

        [Then(@"the “Back To Editor” button should appear")]
        public void ThenTheBackToEditorButtonShouldAppear()
        {
            Assert.IsTrue(test2Page.BacktToeditorBtnIsDisplayed());
        }
    }
}
