using Dynamitey.DynamicObjects;
using OpenQA.Selenium;
using SwagLabsTest.HelperMethods;
using GWD = SwagLabsTest.Support.GWD;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SwagLabsTest.Pages
{
    public class SwagLabsContent : Helpers

    {
 //    private static IWebDriver _driver;
 //    public void SwagLabsContent(IWebDriver driver)
 //    {
 //
 //        this._driver = driver;
 //        PageFactory.InitElement(driver, this);
 //     }           

        private By loginPage = By.CssSelector("[id='login_credentials']");
        private By username = By.Id("user-name");
        private By password = By.Id("password");
        private By loginBtn = By.Id("login-button");
        private By homepage = By.CssSelector("[class='title']");
        private By errorMessage = By.CssSelector("[data-test='error']");
        private By AddBackpack = By.Id("add-to-cart-sauce-labs-backpack");
        private By AddBikeLight = By.Id("add-to-cart-sauce-labs-bike-light");
        private By Cart = By.ClassName("shopping_cart_link");
        private By CheckOut = By.Id("checkout");
        private By name = By.Id("first-name");
        private By lastName = By.Id("last-name");
        private By zipcode = By.Id("postal-code");
        private By Continue=By.Id("continue");
        private By Finish = By.Id("finish");
        private By emptyWarning = By.CssSelector("[class='error-message-container error']");
        private By OrderReceived = By.CssSelector("[class='complete-header']");
        private By RemoveBackpack = By.Id("remove-sauce-labs-backpack");
        private By problemUser = By.CssSelector("[class='error-message-container error']");
        private By filter = By.CssSelector("[class='product_sort_container']");




        //    [FindsBy(How = How.Id, Using = "user-name")]
        //    public IWebElement username;
        //
        //    [FindsBy(How = How.Id, Using = "password")]
        //    public IWebElement password;
        //
        //    [FindsBy(How = How.Id, Using = "login-button")]
        //    public IWebElement loginBtn;

        IWebElement myElement;
        public void sendKeys(string strElement, String value)
        {

            switch (strElement)
            {
                case "username": myElement = GWD.driver.FindElement(username); break;
                case "password": myElement = GWD.driver.FindElement(password); ; break;
                case "name": myElement = GWD.driver.FindElement(name); break;
                case "lastName": myElement = GWD.driver.FindElement(lastName); ; break;
                case "zipcode": myElement = GWD.driver.FindElement(zipcode); ; break;
    }
            sendKeysFunction(myElement, value);

        }
        public void findAndClick(string strElement)
        {

            switch (strElement)
            {
                case "loginBtn": myElement = GWD.driver.FindElement(loginBtn); ; break;
                case "AddBackpack": myElement = GWD.driver.FindElement(AddBackpack); ; break;
                case "AddBikeLight": myElement = GWD.driver.FindElement(AddBikeLight); ; break;
                case "Cart": myElement = GWD.driver.FindElement(Cart); ; break;
                case "CheckOut": myElement = GWD.driver.FindElement(CheckOut); ; break;
                case "Continue":myElement = GWD.driver.FindElement(Continue); ; break;
                case "Finish": myElement = GWD.driver.FindElement(Finish); ; break;
                case "RemoveBackpack": myElement = GWD.driver.FindElement(RemoveBackpack); ; break;
                                       
            }
            clickFunction(myElement);

        }
        public void findAndContainsText(String strElement, String text)
        {
            switch (strElement)
            {
                case "homepage": myElement = GWD.driver.FindElement(homepage); break;
                case "errorMessage": myElement = GWD.driver.FindElement(errorMessage); break;
                case "loginPage": myElement = GWD.driver.FindElement(loginPage); break;
                case "emptyWarning": myElement = GWD.driver.FindElement(emptyWarning); break;
                case "OrderReceived": myElement = GWD.driver.FindElement(OrderReceived); break;
                case "problemUser": myElement = GWD.driver.FindElement(problemUser); break;
                    
            }

            verifyContainsText(myElement, text);
        }

        public void selectFromDropDown(String value)
        {
            SelectElement dropdown = new SelectElement(GWD.driver.FindElement(filter));
            dropdown.SelectByValue(value);            

        }
  
        public class Buttons
        {
            public string ButtonName { get; set; }

        }


    }

}
