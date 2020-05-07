using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestApiProject.NewbookModelsPOM;
using TestApiProject.Tests;

namespace TestApiProject.FF
{
    [Binding]
    public class SignUpSteps
    {
        private IWebDriver _driver = ((IWebDriver)ScenarioContext.Current["driver"]);

        const string PASSWORD = "123qweQWE!";
        const string firstName = "Lora";
        const string lastName = "Smith";
        const string phone = "1111111111";
        private string email = "qweasd" + DateTime.Now.ToString("hhmmss") + "asd@qm.com";

        [Given(@"Sign Up page is opened")]
        public void GivenSignUpPageIsOpened()
        {
            new SignUpPage(_driver).SignInPageOpened();
        }
        
        [When(@"I input email in email field")]
        public void WhenIInputEmailInEmailField()
        {
            new SignUpPage(_driver).FillEmailField(email);
        }
        
        [When(@"I input default password in password field")]
        public void WhenIInputDefaultPasswordInPasswordField()
        {
            new SignUpPage(_driver).FillPasswordField(PASSWORD);
        }

        [When(@"I input password in confirmPassword field")]
        public void WhenIInputPasswordInConfirmPasswordField()
        {
            new SignUpPage(_driver).FillConfirmPasswordField(PASSWORD);
        }

        [When(@"I input first name in firstName field")]
        public void WhenIInputFirstNameInFirstNameField()
        {
            new SignUpPage(_driver).FillFirstNameField(firstName);
        }

        [When(@"I input last name in lastName field")]
        public void WhenIInputLastNameInLastNameField()
        {
            new SignUpPage(_driver).FillLastNameField(lastName);
        }

        [When(@"I input mobile in mobile field")]
        public void WhenIInputMobileInMobileField()
        {
            Thread.Sleep(3000);
            new SignUpPage(_driver).FillPhoneField(phone);
        }

        [When(@"I click Sign up button")]
        public void WhenIClickSignUpButton()
        {
            new SignUpPage(_driver).ClickSignUpButton();
        }
        
        [Then(@"Client is successfully Signed Up as a client")]
        public void ThenClientIsSuccessfullySignedUpAsAClient()
        {
            Assert.True(new ClientSignUpPage(_driver).IsUrlInputDisplayed());
        }
    }
}
