using IHSMarkit_PCM.Hooks;
using IHSMarkit_PCM.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHSMarkit_PCM.PageObjects
{
    public class Test2Page
    {
        IWebDriver Driver = DriverHelper.Driver;

        Waits waits = new Waits();


        IWebElement PackageName => Driver.FindElement(By.CssSelector("input[type='search']"));
        IWebElement Nunit => Driver.FindElement(By.CssSelector("#menu > li:nth-child(1) > a"));
        IWebElement VersionName => Driver.FindElement(By.CssSelector("#menu > li:nth-child(1) > ul > li:nth-child(1) > a"));
        IWebElement NunitPackage => Driver.FindElement(By.CssSelector("div[package-id='NUnit']"));
        IWebElement Share => Driver.FindElement(By.CssSelector("#Share"));
        IWebElement ShareLink => Driver.FindElement(By.CssSelector("#ShareLink"));
        IWebElement SideBar=> Driver.FindElement(By.CssSelector("button[class$='sidebar-toggle']"));
        IWebElement OptionPanel => Driver.FindElement(By.CssSelector("a[href='/contact']"));
        //IWebElement OptionPanel => Driver.FindElement(By.CssSelector("div[class='sidebar unselectables']"));
        IWebElement SaveBtn => Driver.FindElement(By.CssSelector("#save-button"));
        IWebElement LogInWindow => Driver.FindElement(By.CssSelector("#login-modal-label"));
        IWebElement GettingStarted => Driver.FindElement(By.CssSelector("a[href = '/GettingStarted/']"));
        IWebElement BackToEditorBtn => Driver.FindElement(By.CssSelector("div.navbar-center-container > div:nth-child(1)"));

        public void EnterPackageName(string packagename)
        {
            PackageName.SendKeys(packagename);
           
        }

        public void ClickVersion()
        {

            Nunit.Click();
            VersionName.Click();

        }
        public bool NunitPackageIsDisplayed()
        {

            return waits.WaitForElement(Driver, NunitPackage).Displayed;

        }

        public void ClickShare()
        {
            
            Share.Click();

        }
        public string GetShareLink()
        {

            return ShareLink.Text;

        }
        public void ClickSidebar()
        {

            SideBar.Click();

        }

        public bool OptionPanelIsDisplayed()
        {

             return waits.WaitForElement(Driver, OptionPanel).Enabled;

        }

        public void ClickSaveBtn()
        {

            SaveBtn.Click();

        }
        public bool LogInWindowIsDisplayed()
        {

            return waits.WaitForElement(Driver, LogInWindow).Displayed;

        }
        public void ClickGetingStarted()
        {

           GettingStarted.Click();

        }
        public bool BacktToeditorBtnIsDisplayed()
        {

            return waits.WaitForElement(Driver, BackToEditorBtn).Displayed;

        }
    }
}
