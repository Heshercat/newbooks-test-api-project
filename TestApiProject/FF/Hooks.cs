using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestApiProject.FF
{
    [Binding]
    class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            ScenarioContext.Current["driver"] = driver;
        }
        [AfterScenario]
        public void AfterScenario()
        {
            ((IWebDriver)ScenarioContext.Current["driver"]).Quit();
        }
    }
}
