using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestApiProject.ApiRequests.Models;
using TestApiProject.ApiRequests.NewBookModelsApi.Auth;
using TestApiProject.NewbookModelsPOM;
using TestApiProject.Tests;

namespace TestApiProject.FF.Steps
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver _driver = ((IWebDriver)ScenarioContext.Current["driver"]);
        
        const string PASSWORD = "123qweQWE!";

        [Given(@"Client is created")]
        public void GivenClientIsCreated()
        {
           // var expectedEmail = EMAIL;
            ScenarioContext.Current["client"] = new AuthRequests().SendRequestSignUpPost(new ClientSignUpModel
            {
                Email = "qweasd" + DateTime.Now.ToString("hhmmss")+ "asd@qm.com",
                Password = PASSWORD,
                FirstName = "sdfsadfsf",
                LastName = "asdadasdsad",
                PhoneNumber = "1231231231"
            });
        }
        
        [Given(@"Sign in page is opened")]
        public void GivenSignInPageIsOpened()
        {
            new SignInPage(_driver).SignInPageOpened();
        }
        
        [When(@"I input email of created lead in email field")]
        public void WhenIInputEmailOfCreatedLeadInEmailField()
        {
            var client = ((ClientAuthModel)ScenarioContext.Current["client"]);
            new SignInPage(_driver).FillEmailField(client.User.Email);
        }
        
        [When(@"I input default password of created lead in password field")]
        public void WhenIInputDefaultPasswordOfCreatedLeadInPasswordField()
        {
            new SignInPage(_driver).FillPasswordField(PASSWORD);
            
        }
        
        [When(@"I click Sign in button")]
        public void WhenIClickSignInButton()
        {
            new SignInPage(_driver).ClickSignInButton();
        }
        
        [Then(@"Client is successfully logged as created client")]
        public void ThenClientIsSuccessfullyLoggedAsCreatedClient()
        {
            Assert.True(new ClientSignUpPage(_driver).IsFinishButtonDisplayed());  
        }
    }
}
