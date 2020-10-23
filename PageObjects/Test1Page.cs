using IHSMarkit_PCM.Hooks;
using IHSMarkit_PCM.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHSMarkit_PCM.PageObjects
{
    class Test1Page
    {
        IWebDriver Driver = DriverHelper.Driver;

        Waits waits = new Waits();


        IWebElement RunButton => Driver.FindElement(By.Id("run-button"));

        IWebElement WindowOutput => Driver.FindElement(By.CssSelector("div[id='output']"));


        public void NavigateTowebsite(string url)
        {
            Driver.Navigate().GoToUrl(url);

        }

        public void ClickRunButton()
        {
            RunButton.Click();
        }

      

        public bool WindowOutputIsDisplayed()
        {
            return waits.WaitForElement(Driver, WindowOutput).Displayed;
        }
    }
}
