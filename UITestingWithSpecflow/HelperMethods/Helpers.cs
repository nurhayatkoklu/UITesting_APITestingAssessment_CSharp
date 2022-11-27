using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FronEndTesting.HelperMethods
{
    public class Helpers

    {
       

        public void sendKeysFunction(WebElement element, String value)
        {
            waitUntilVisible(element);
            scrollToElement(element);
            element.Clear();
            element.SendKeys(value);
        }

        public void waitUntilVisible(WebElement element)
        {
  



        }
        public void scrollToElement(WebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

        }

        public void clickFunction(WebElement element)
        {
            waitUntilClickable(element); 
            scrollToElement(element); 
            element.Click(); 
        }
        public void waitUntilClickable(WebElement element)
        {
  
        }

        public void verifyContainsText(WebElement element, String text)
        {

        }

        public void waitUntilLoading()
        {

        }

  
    }
}
