using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luma.Pages
{
    public class AddressPage
    {
        public AddressPage(WebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "[name='firstName']")]
        private IWebElement FirstName;

        [FindsBy(How=How.Name,Using =("lastName"))]
        private IWebElement LastName;
        [FindsBy(How=How.Id,Using = "postal-code")]
        private IWebElement Zipcode;
        [FindsBy(How=How.Name,Using =("continue"))]
        private IWebElement ContinueButton;
        [FindsBy(How=How.CssSelector,Using=("[name='finish']"))]
        private IWebElement ExitButton;
        public void AddressDetails(string firstName, string lastName, string zipCode)
        {
            FirstName.SendKeys(firstName);
            LastName.SendKeys(lastName);
            Zipcode.SendKeys(zipCode);
            ContinueButton.Click();
            ExitButton.Click();


        }
       
    }
}
