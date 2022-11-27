using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SwagLabsTest.Support;
using System.Reflection;
using TechTalk.SpecFlow;

namespace SwagLabsTest.StepDefinitions
{
    [Binding]
    public class Hook

    {


        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            
            Console.WriteLine("Test Scenario Started...");
            GWD.startDriver();
            GWD.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            GWD.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GWD.driver.Manage().Window.Maximize();

        }


        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Test Scenario Ended Successfully...");
            GWD.QuitDriver();
        }
    }
}