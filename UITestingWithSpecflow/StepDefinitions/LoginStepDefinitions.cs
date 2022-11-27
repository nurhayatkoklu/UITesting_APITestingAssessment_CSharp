using FronEndTesting.HelperMethods;
using FronEndTesting.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace FronEndTesting.StepDefinitions 
{
    [Binding]
    public class LoginStepDefinitions : Helpers
    {
       
        WebElements we = new WebElements();
        
        [Given(@"Navigate to basqar")]
        public void GivenNavigateToBasqar()
        {
            we.navigateToBasqar();
        }

        [When(@"Enter username and password and click login button")]
        public void WhenEnterUsernameAndPasswordAndClickLoginButton()
        {
            we.sendKeys("username", "");
            we.sendKeys("password", "");
            we.findAndClick("loginBtn");
        }

        [Then(@"User should login successfully")]
        public void ThenUserShouldLoginSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"Enter invalid username and valid password and click login button")]
        public void WhenEnterInvalidUsernameAndValidPasswordAndClickLoginButton()
        {
            throw new PendingStepException();
        }

        [When(@"Enter valid username and invalid password and click login button")]
        public void WhenEnterValidUsernameAndInvalidPasswordAndClickLoginButton()
        {
            throw new PendingStepException();
        }
    }
}
