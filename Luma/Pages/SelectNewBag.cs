using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luma.Pages
{
    public class SelectNewBag
    {
        public SelectNewBag(WebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sauce Labs Backpack']")]
        private IWebElement NewBag;

        [FindsBy(How = How.XPath, Using = "//button[text()='Add to cart']")]
        private IWebElement AddToCart;

        [FindsBy(How=How.Id,Using = "shopping_cart_container")]
        private IWebElement CheckCart;

        [FindsBy(How=How.Name,Using = "checkout")]
        private IWebElement CheckoutCart;

        public void SetNewBag()
        {
            NewBag.Click();
            Thread.Sleep(5000);
            AddToCart.Click();
            Thread.Sleep(5000);
            CheckCart.Click();
            //((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("bag.png");
            Thread.Sleep(5000);
            CheckoutCart.Click();
            Thread.Sleep(5000);
        }
    }
}
