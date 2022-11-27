using SwagLabsTest.Pages;
using System;
using TechTalk.SpecFlow;

namespace SwagLabsTest.StepDefinitions
{
    [Binding]
    public class DiscoverWhatIsWrongWithTheProblem_UserSteps
    {
        SwagLabsContent slc = new SwagLabsContent();
        [When(@"Take the screenshot if user is able to fill the form")]
        public void WhenTakeTheScreenshotIfUserIsAbleToFillTheForm()
        {
            slc.takeProblemScreenShot();

        }

        [Then(@"Verify the problem of problem_user")]
        public void ThenVerifyTheProblemOfProblem_User()
        {
            slc.findAndContainsText("problemUser", "is required");
        }
    }
}
