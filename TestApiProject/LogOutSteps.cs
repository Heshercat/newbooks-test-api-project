using System;
using TechTalk.SpecFlow;

namespace TestApiProject
{
    [Binding]
    public class LogOutSteps
    {
        [When(@"I click personal Settings Button")]
        public void WhenIClickPersonalSettingsButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
