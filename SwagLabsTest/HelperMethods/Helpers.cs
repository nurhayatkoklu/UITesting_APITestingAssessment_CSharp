using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwagLabsTest.Support;
using SeleniumExtras.WaitHelpers;
using Dynamitey.Internal.Optimization;
using Dynamitey;
using System.Xml.Schema;

namespace SwagLabsTest.HelperMethods
{
    public class Helpers 
    {
        public void sendKeysFunction(IWebElement element, String value)
        {
            // waitUntilVisible(element); 
            // scrollToElement(element);
            GWD.Wait(1);
            element.Clear();
            element.SendKeys(value); 
        }

    //   public void waitUntilVisible(IWebElement element)
    //   {
    //       WebDriverWait wait = new WebDriverWait(GWD.driver, TimeSpan.FromSeconds(30));
    //       wait.Until(ExpectedConditions.ElementExists(element));
    //   }

        public void clickFunction(IWebElement element)
        {
            //  waitUntilClickable(element);
            //  scrollToElement(element);
            GWD.Wait(1);
            element.Click();    
        }

        public void verifyContainsText(IWebElement element, string text)
        {
            // waitUntilVisible(element);
            GWD.Wait(1);
            Assert.True(element.Text.ToLower().Contains(text.ToLower()));
        }

        public void takePaymentInfoScreenShot()        {

            DateTime aDate = DateTime.Now;
            string photoname = "PaymentInformation"+aDate.ToString("MMddyyyyHHmm")+".png";
            Screenshot ss = ((ITakesScreenshot)GWD.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Nurhayat\Desktop\Console\PetStoreAPI\SwagLabsTest\ScreenShot\\"+photoname,
            ScreenshotImageFormat.Png);
        }

        public void takeProblemScreenShot()
        {

            DateTime aDate = DateTime.Now;
            string photoname = "ProblemOfproblem_user" + aDate.ToString("MMddyyyyHHmm") + ".png";
            Screenshot ss = ((ITakesScreenshot)GWD.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Nurhayat\Desktop\Console\PetStoreAPI\SwagLabsTest\ScreenShot\\" + photoname,
            ScreenshotImageFormat.Png);
        }

        //  public void scrollToElement(IWebElement element)
        //  {
        //      ((IJavaScriptExecutor)GWD.driver).ExecuteScript("arguments[0].scrollIntoView(true);", //element);
        //  }

        //   public void waitUntilClickable(IWebElement element)
        //   {
        //       WebDriverWait wait = new WebDriverWait(GWD.driver, TimeSpan.FromSeconds(30));
        //       wait.Until(ExpectedConditions.ElementToBeClickable(element));
        //   }
    }
}

