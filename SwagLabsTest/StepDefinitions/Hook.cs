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


        }


        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Test Scenario Ended Successfully...");
            GWD.QuitDriver();
        }
    }
}