using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApiProject.NewbookModelsPOM
{
    public class ProfileSettingsPage
    {
        private IWebDriver _driver;
        public ProfileSettingsPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private static readonly By logOutLink = By.CssSelector("div[class*=link_type_logout]");
        private static readonly By profilelSettingsButton = By.CssSelector("div[class=AvatarClient__avatar]");
        public void ClickProfilelSettingsButton()
        {
            Thread.Sleep(2000);
            _driver.FindElement(profilelSettingsButton).Click();
        }
        public void ClickLogOutLink()
        {
            _driver.FindElement(logOutLink).Click();
        }
        public void ProfileSettingsPageIsOpened()
        {
            _driver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
        }

    }
}
