using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Pages
{
    public class SwagLabsHomePage
    {
         WebDriver driver;   
        public SwagLabsHomePage(WebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[text()='Sauce Labs Onesie']")]

        IWebElement SauceLabsOnseiItem;

        [FindsBy(How = How.XPath, Using = ("//div[text()='Sauce Labs Onesie']"))]

        IWebElement SauceTextVerification;

        [FindsBy(How = How.XPath, Using = "//button[text()='Add to cart']")]

        IWebElement AddItemintoCart;

        [FindsBy(How=How.XPath,Using ="//span[@class='shopping_cart_badge']")]
            IWebElement CheckSwagLabItemInCart;


        public void SwaglabhomePageScroll()
        {
           IJavaScriptExecutor jse=driver as IJavaScriptExecutor;

            jse.ExecuteScript("scrollBy(0,500)");

            SauceLabsOnseiItem.Click();

            Console.WriteLine(SauceTextVerification);

            Thread.Sleep(3000);

            AddItemintoCart.Click();

            Thread.Sleep(3000);

            CheckSwagLabItemInCart.Click();

        }
    }
}
