using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.Network;
using SwagLabsTest.Pages;
using SwagLabsTest.Support;
using System;
using TechTalk.SpecFlow;

namespace SwagLabsTest.StepDefinitions
{
    [Binding]
    public class FilterFunctionalityTestSteps
    {
        SwagLabsContent slc = new SwagLabsContent();
        [When(@"Select NameAToZ")]
        public void WhenSelectNameAToZ()
        {
            slc.selectFromDropDown("az");
            GWD.Wait(1);


        }

        [When(@"Verift that products sorted from A to Z")]
        public void WhenVeriftThatProductsSortedFromAToZ()
        {
            IList<IWebElement> productList = GWD.driver.FindElements(By.CssSelector("[class='inventory_list']"));
            var alphabetical = true;
            for (int i = 0; i < productList.Count - 1; i++)
            {
                if (StringComparer.Ordinal.Compare(productList[i], productList[i + 1]) > 0)
                {
                    alphabetical = false;
                    break;
                }
            }
            Assert.True(alphabetical);
        }

        [When(@"Select NameZToZ")]
        public void WhenSelectNameZToZ()
        {
            slc.selectFromDropDown("za");
            GWD.Wait(1);
        }

        [When(@"Verift that products sorted from Z to A")]
        public void WhenVeriftThatProductsSortedFromZToA()
        {
            IList<IWebElement> productList = GWD.driver.FindElements(By.CssSelector("[class='inventory_list']"));
            var alphabetical = true;
            for (int i = 0; i < productList.Count - 1; i++)
            {
                if (StringComparer.Ordinal.Compare(productList[i], productList[i + 1]) < 0)
                {
                    alphabetical = false;
                    break;
                }
            }
            Assert.True(alphabetical);
        }

        [When(@"Select LowToHigh")]
        public void WhenSelectLowToHigh()
        {
            slc.selectFromDropDown("lohi");
            GWD.Wait(1);
        }

        [When(@"Verift that products sorted from low to high")]
        public void WhenVeriftThatProductsSortedFromLowToHigh()
        {
            IList<IWebElement> priceList = GWD.driver.FindElements(By.CssSelector("[class='inventory_item_price']"));
            List<string> priceListStr = new List<string>();
            List<double> priceListDouble = new List<double>();
            for (int i = 0; i < priceList.Count; i++)
            {
                priceListStr.Add(priceList[i].Text.ToString().Substring((priceList[i].Text.ToString().IndexOf("$")+1), (priceList[i].Text.ToString().Length -1)));
                Console.WriteLine(priceListStr[i]);
            }
            for (int i = 0; i < priceListStr.Count; i++)
            {
                priceListDouble.Add(Double.Parse(priceListStr[i]));
                Console.WriteLine(priceListDouble[i]);
            }
                var pricefilter = true;

            for (int i = 0; i < priceListDouble.Count - 1; i++)
            {
                if (priceListDouble[i] > priceListDouble[i+1]) {
                    pricefilter= false; break;
                }

            }
            Assert.True(pricefilter);
        }

        [When(@"Select HighToLow")]
        public void WhenSelectHighToLow()
        {
            slc.selectFromDropDown("hilo");
            GWD.Wait(1);
        }

        [Then(@"Verift that products sorted from high to low")]
        public void ThenVeriftThatProductsSortedFromHighToLow()
        {
            IList<IWebElement> priceList = GWD.driver.FindElements(By.CssSelector("[class='inventory_item_price']"));

            List<string> priceListStr = new List<string>();
            List<double> priceListDouble = new List<double>();
            for (int i = 0; i < priceList.Count; i++)
            {
                priceListStr.Add(priceList[i].Text.ToString().Substring((priceList[i].Text.ToString().IndexOf("$")+1), (priceList[i].Text.ToString().Length)-1));
            }
            for (int i = 0; i < priceListStr.Count; i++)
            {
                priceListDouble.Add(Double.Parse(priceListStr[i]));
            }
            var pricefilter = true;

            for (int i = 0; i < priceListDouble.Count - 1; i++)
            {
                if (priceListDouble[i] < priceListDouble[i + 1])
                {
                    pricefilter = false; break;
                }

            }
            Assert.True(pricefilter);
        }

    }
}
