
using SwagLabsTest.Pages;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;
using SwagLabsTest.Support;

namespace SwagLabsTest.StepDefinitions
{
    [Binding]
    public class LoginTestSteps
    {
        SwagLabsContent slc = new SwagLabsContent();

        [Given(@"Navigate To basqar")]
        public void GivenNavigateToBasqar()
        {
            slc.GivenNavigateToBasqar();
        }

        [When(@"Enter valid username and password and click login button")]
        public void WhenEnterValidUsernameAndPasswordAndClickLoginButton()
        {
            slc.sendKeys("username", "standard_user");
            slc.sendKeys("password", "secret_sauce");
            slc.findAndClick("loginBtn");
        }

        [Then(@"User should login successfully")]
        public void ThenUserShouldLoginSuccessfully()
        {
            slc.findAndContainsText("homepage", "Products");
        
        }

        [When(@"Enter invalid username and valid password and click login button")]
        public void WhenEnterInvalidUsernameAndValidPasswordAndClickLoginButton()
        {
            slc.sendKeys("username", "nurhayat");
            slc.sendKeys("password", "secret_sauce");
            slc.findAndClick("loginBtn");

        }

        [When(@"Enter valid username and invalid password and click login button")]
        public void WhenEnterValidUsernameAndInvalidPasswordAndClickLoginButton()
        {
            slc.sendKeys("username", "standard_user");
            slc.sendKeys("password", "nurhayat");
            slc.findAndClick("loginBtn");

        }
      
         [Then(@"User cannot be login successfully")]
         public void ThenUserCannotBeLoginSuccessfully()
            {
            slc.findAndContainsText("errorMessage", "Epic sadface");

        }

        [When(@"Confirm you are on the login page")]
        public void WhenConfirmYouAreOnTheLoginPage()
        {
            slc.findAndContainsText("loginPage", "Accepted usernames");
        }

        [When(@"Enter invalid username and invalid password and click login button")]
        public void WhenEnterInvalidUsernameAndInvalidPasswordAndClickLoginButton()
        {
            slc.sendKeys("username", "nurhayat");
            slc.sendKeys("password", "nurhayat");
            slc.findAndClick("loginBtn");
        }

        [When(@"Do not enter any username and password and click login button")]
        public void WhenDoNotEnterAnyUsernameAndPasswordAndClickLoginButton()
        {
            slc.sendKeys("username", "");
            slc.sendKeys("password", "");
            slc.findAndClick("loginBtn");
        }

        [Then(@"Verify empty username warning")]
        public void ThenVerifyEmptyUsernameWarning()
        {
            slc.findAndContainsText("emptyWarning", "is required");
        }

        [When(@"Do not enter any username and enter a valid password and click login button")]
        public void WhenDoNotEnterAnyUsernameAndEnterAValidPasswordAndClickLoginButton()
        {
            slc.sendKeys("username", "");
            slc.sendKeys("password", "secret_sauce");
            slc.findAndClick("loginBtn");
        }

        [When(@"Enter a valid username and do not enter password and click login button")]
        public void WhenEnterAValidUsernameAndDoNotEnterPasswordAndClickLoginButton()
        {
            slc.sendKeys("username", "standard_user");
            slc.sendKeys("password", "");
            slc.findAndClick("loginBtn");
        }

    }
}
