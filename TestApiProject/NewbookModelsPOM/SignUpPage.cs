using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiProject.NewbookModelsPOM
{
    public class SignUpPage
    {
        private IWebDriver _driver;
        public SignUpPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private static readonly By firstNameField = By.Name("first_name");
        private static readonly By lastNameField = By.Name("last_name");
        private static readonly By emailField = By.Name("email");
        private static readonly By passwordField = By.Name("password");
        private static readonly By confirmPasswordField = By.Name("password_confirm");
        private static readonly By phoneField = By.CssSelector("input[placeholder='555.867.5309']");
        private static readonly By signUpBtn = By.CssSelector("button[class^=SignupForm]");

        public void FillEmailField(string email)
        {
            _driver.FindElement(emailField).SendKeys(email);
        }
        public void FillFirstNameField(string firstName)
        {
            _driver.FindElement(firstNameField).SendKeys(firstName);
        }
        public void FillLastNameField(string lastName)
        {
            _driver.FindElement(lastNameField).SendKeys(lastName);
        }
        public void FillPasswordField(string password)
        {
            _driver.FindElement(passwordField).SendKeys(password);
        }
        public void FillConfirmPasswordField(string confirmPassword)
        {
            _driver.FindElement(confirmPasswordField).SendKeys(confirmPassword);
        }
        public void FillPhoneField(string phone)
        {
            _driver.FindElement(phoneField).SendKeys(phone);
        }
        public void ClickSignUpButton()
        {
            _driver.FindElement(signUpBtn).Click();
        }

        public void SignInPageOpened()
        {
            _driver.Navigate().GoToUrl("https://newbookmodels.com/join");
        }
    }
}
