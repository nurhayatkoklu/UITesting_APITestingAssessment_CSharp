using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsTest.Support;
using System;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;

namespace SwagLabsTest.StepDefinitions
{
    [Binding]
    public class RemoveProductTestSteps
    {
        [When(@"Verify product is removed from the cart")]
        public void WhenVerifyProductIsRemovedFromTheCart()
        {            
            ReadOnlyCollection<IWebElement> list = GWD.driver.FindElements(By.CssSelector("[class='cart_list']"));           
            Assert.AreEqual(1, list.Count);
        }
    }
}
