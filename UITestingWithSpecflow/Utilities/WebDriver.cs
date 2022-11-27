using LivingDoc.SpecFlowPlugin;
using log4net;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FronEndTesting.Utilities
{
    public class WebDriver
    {
        [Test]
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            return option;
        }

        private static ChromeDriver GetChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
            [BeforeFeature()]
            public static void InitWebdriver(TestContext tc)
            {
                ObjectRepository.Config = new AppConfigReader();
                Reporter.GetReportManager();
                Reporter.AddTestCaseMetadataToHtmlReport(tc);
                switch (ObjectRepository.Config.GetBrowser())
                {
                    case BrowserType.Firefox:
                        ObjectRepository.Driver = GetFirefoxDriver();
                        Logger.Info(" Using Firefox Driver  ");

                        break;

                    case BrowserType.Chrome:
                        ObjectRepository.Driver = GetChromeDriver();
                        Logger.Info(" Using Chrome Driver  ");
                        break;

                    case BrowserType.IExplorer:
                        ObjectRepository.Driver = GetIEDriver();
                        Logger.Info(" Using Internet Explorer Driver  ");
                        break;

                    case BrowserType.PhantomJs:
                        ObjectRepository.Driver = GetPhantomJsDriver();
                        Logger.Info(" Using PhantomJs Driver  ");
                        break;

                    default:
                        throw new NoSutiableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());
                }
                ObjectRepository.Driver.Manage()
                    .Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
                BrowserHelper.BrowserMaximize();
            }


            [AssemblyCleanup]
            //[AfterScenario()]
            public static void TearDown()
            {
                if (ObjectRepository.Driver != null)
                {
                    ObjectRepository.Driver.Close();
                    ObjectRepository.Driver.Quit();
                }
                Logger.Info(" Stopping the Driver  ");
            }
        }
    }