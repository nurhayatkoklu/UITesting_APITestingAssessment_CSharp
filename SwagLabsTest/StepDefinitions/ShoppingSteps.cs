using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabsTest.Pages;
using SwagLabsTest.Support;
using System;
using System.Configuration;
using System.Reflection.Emit;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static SwagLabsTest.Pages.SwagLabsContent;

namespace SwagLabsTest.StepDefinitions
{
    [Binding]
    public class ShoppingSteps
    {
        double backpackPrice;
        double bikelightPrice;
        SwagLabsContent slc = new SwagLabsContent();
        [Given(@"Click below buttons")]
        public void GivenClickBelowButtons(Table table)
        {
            backpackPrice = Double.Parse(GWD.driver.FindElement(By.XPath("(//*[@class='inventory_item_price'])[1]")).Text.ToString().Replace("$", ""));
            bikelightPrice = Double.Parse(GWD.driver.FindElement(By.XPath("(//*[@class='inventory_item_price'])[2]")).Text.ToString().Replace("$", ""));
            var buttons = table.CreateSet<Buttons>();          
                    
           for (int i=0; i < buttons.Count(); i++)
            {
                slc.findAndClick(buttons.ElementAt(i).ButtonName);
            }     

        }

        [When(@"Fill the form with ""([^""]*)"", ""([^""]*)"" and ""([^""]*)""")]
        public void WhenFillTheFormWithAnd(string FirstName, string LastName, string Zipcode)
        {
            slc.sendKeys("name", FirstName);
            slc.sendKeys("lastName", LastName);
            slc.sendKeys("zipcode", Zipcode);
    }

        [When(@"Click below buttons")]
        public void WhenClickBelowButtons(Table table)
        {
            var buttons = table.CreateSet<Buttons>();

            for (int i = 0; i < buttons.Count(); i++)
            {
                slc.findAndClick(buttons.ElementAt(i).ButtonName);
               
            }
        }

        [Then(@"Click below buttons")]
        public void ThenClickBelowButtons(Table table)
        {
            var buttons = table.CreateSet<Buttons>();

            for (int i = 0; i < buttons.Count(); i++)
            {
                slc.findAndClick(buttons.ElementAt(i).ButtonName);
            }
        }
        [When(@"Take the screenshot of payment information")]
        public void WhenTakeTheScreenshotOfPaymentInformation()
        {
            slc.takePaymentInfoScreenShot();
        }

        [Then(@"Confirm order is dispatched")]
        public void ThenConfirmOrderIsDispatched()
        {
            slc.findAndContainsText("OrderReceived", "Thank You");
        }

        [When(@"Verify total payment amount is correct")]
        public void WhenVerifyTotalPaymentAmountIsCorrect()
        {
            
            double tax= Double.Parse(GWD.driver.FindElement(By.CssSelector("[class='summary_tax_label']")).Text.ToString().Replace("Tax: $", ""));
            double totalActual= Double.Parse(GWD.driver.FindElement(By.CssSelector("[class=summary_total_label]")).Text.ToString().Replace("Total: $", ""));          
            double totalExpected = backpackPrice + bikelightPrice + tax;
            Assert.AreEqual(totalExpected, totalActual);


        }

    }
}
