using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestApiProject.ApiRequests.NewBookModelsApi.Auth;
using TestApiProject.NewbookModelsPOM;
using TestApiProject.Tests;

namespace TestApiProject.FF
{
    [Binding]
    public class LogOutSteps
    {
        private IWebDriver _driver = ((IWebDriver)ScenarioContext.Current["driver"]);
        
        const string USER_EMAIL = "qweasd";
        const string PASSWORD = "123qweQWE!";

        [Given(@"I create client using API")]
        public void GivenICreateClientUsingAPI()
        {
            Context.Token = new AuthRequests().SendRequestSignUpPost(new ClientSignUpModel
            {
                Email = USER_EMAIL + DateTime.Now.ToString("hhmmss") + "@jhh.com",
                Password = PASSWORD,
                FirstName = "sdfsadfsf",
                LastName = "asdadasdsad",
                PhoneNumber = "1231231231"
            }).TokenData.Token;
        }

        [Given(@"I successfully logged using API")]
        public void GivenISuccessfullyLoggedUsingAPI()
        {
            IJavaScriptExecutor js = (ChromeDriver)_driver;
            js.ExecuteScript($"localStorage.setItem('access_token','{Context.Token}');");
           
        }
        
        [When(@"I click profile Settings Button")]
        public void WhenIClickProfileSettingsButton()
        {
            Thread.Sleep(3000);
            new ProfileSettingsPage(_driver).ProfileSettingsPageIsOpened();
        }

        [When(@"I click Log Out reference")]
        public void WhenIClickLogOutReference()
        {
            new ProfileSettingsPage(_driver).ClickLogOutLink();
        }

        [Then(@"Client is successfully Log Out from NewBook")]
        public void ThenClientIsSuccessfullyLogOutFromNewBook()
        {
            Assert.True(new SignInPage(_driver).IsDisplayedSignInButton());
        }
    }
}
