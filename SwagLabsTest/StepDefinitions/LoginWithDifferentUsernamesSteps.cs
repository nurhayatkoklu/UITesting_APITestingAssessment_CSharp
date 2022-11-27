using NUnit.Framework.Internal;
using SwagLabsTest.Pages;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace SwagLabsTest.StepDefinitions
{
    [Binding]
    public class LoginWithDifferentUsernamesSteps
    {
        SwagLabsContent slc = new SwagLabsContent();
        [When(@"Enter ""([^""]*)"" and password and click login button")]
        public void WhenEnterAndPasswordAndClickLoginButton(string username)
        {
            slc.sendKeys("username", username);
            slc.sendKeys("password", "secret_sauce");
            slc.findAndClick("loginBtn");

        }

        [Then(@"Check if the user can login with different usernames")]
        public void ThenCheckIfTheUserCanLoginWithDifferentUsernames()
        {
            slc.findAndContainsText("homepage", "Products");
        }

        [When(@"Enter locked_user username and password and click login button")]
        public void WhenEnterLocked_UserUsernameAndPasswordAndClickLoginButton()
        {
            slc.sendKeys("username", "locked_out_user");
            slc.sendKeys("password", "secret_sauce");
            slc.findAndClick("loginBtn");
        }
    }
}
