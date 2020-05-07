using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApiProject.NewbookModelsPOM
{
    public class SignInPage
    {
        private IWebDriver _driver;
        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private static readonly By emailField = By.CssSelector("input[type=email]");
        private static readonly By passwordField = By.CssSelector("input[type=password]");
        private static readonly By loginBtn = By.CssSelector("button[class^=SignInForm]");

        public void FillEmailField(string email)
        {
            _driver.FindElement(emailField).SendKeys(email);
        }
        public void FillPasswordField(string password)
        {
            _driver.FindElement(passwordField).SendKeys(password);
        }
        public void ClickSignInButton()
        {
            _driver.FindElement(loginBtn).Click();
        }
        public bool IsDisplayedSignInButton()
        {
            Thread.Sleep(1000);
            return _driver.FindElement(loginBtn).Displayed;
        }

        public void SignInPageOpened()
        {
            _driver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");
        }
    }
}
