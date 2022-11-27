using FronEndTesting.HelperMethods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FronEndTesting.PageObjects
{
    public class WebElements : Helpers
    {
        private WebElement username = (WebElement)driver.FindElement(By.Id("username"));
        private WebElement password = (WebElement)driver.FindElement(By.Id("password"));
        private WebElement loginBtn = (WebElement)driver.FindElement(By.Id("login-button"));

        WebElement myElement;
        public void sendKeys(String strElement, String value)
        {
      
            switch(strElement)
            {
                case "username": myElement = username; break;
                case "password": myElement = password; break;
               
            }
            sendKeysFunction(myElement, value);
        }
        public void findAndClick(String strElement)
        {

            switch (strElement)
            {
                case "loginBtn": myElement = loginBtn; break;
             

            }
            clickFunction(myElement);
        }
        public void navigateToBasqar()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");


        }
    }

   
}
