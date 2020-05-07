using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApiProject.Tests
{
    public class ClientSignUpPage
    {
        private IWebDriver _driver;
        public ClientSignUpPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private static readonly By finishButton = By.XPath("/html/body/nb-app/nb-signup-company/common-react-bridge/div/div[2]/div/section/section/div/form/section/section/div/div[2]/section/div/div/button");
        private static readonly By urlInput = By.Id("SIGNUP_FIRST_FORM/industry");
        public bool IsFinishButtonDisplayed()
        {
            Thread.Sleep(5000);
            return _driver.FindElement(finishButton).Displayed;
        }
        public bool IsUrlInputDisplayed()
        {
            Thread.Sleep(5000);
            return _driver.FindElement(urlInput).Displayed;
        }
    }
}
