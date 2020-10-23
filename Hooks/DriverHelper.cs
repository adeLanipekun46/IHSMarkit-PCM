using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace IHSMarkit_PCM.Hooks
{
    [Binding]
    public sealed class DriverHelper
    {
        public static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {



                Driver = new ChromeDriver();

                Driver.Manage().Window.Maximize();

                Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);


            }

        

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }


}
