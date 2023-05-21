using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Pages
{
    public class SwagLabsItemInCartCheckoutPage
    {
        public SwagLabsItemInCartCheckoutPage(WebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "[name='checkout']")]
        IWebElement SwagLabCartCheck;

        [FindsBy(How = How.CssSelector, Using = ("[id='first-name']"))]
        IWebElement SwagLabUserFirstName;

        [FindsBy(How=How.CssSelector,Using = "[name='lastName']")]
        IWebElement SwagLabUserLastName;

        [FindsBy(How=How.CssSelector,Using = "[id='postal-code']")]
        IWebElement SwagLabUserAreaZipCode;

        [FindsBy(How=How.Name,Using = "continue")]
        IWebElement ContinueButton;

        [FindsBy(How = How.XPath, Using = "//button[text()='Finish']")]
        IWebElement SwagLabFinishpayment;

        [FindsBy(How = How.XPath, Using = "//h2[text()='Thank you for your order!']")]
        IWebElement OrderConfirmation;

        [FindsBy(How = How.XPath, Using = "//button[text()='Back Home']")]
        IWebElement Backtohome;
        public void SwagLabcartcheckout()
        {
          SwagLabCartCheck.Click(); 

        }
        public void VerifySwagLabCustomerDetails(string firstName,string LastName,string Zipcode)
        {
            SwagLabUserFirstName.SendKeys(firstName);

            SwagLabUserLastName.SendKeys(LastName);

            SwagLabUserAreaZipCode.SendKeys(Zipcode);

           ContinueButton.Click();

            SwagLabFinishpayment.Click();

            OrderConfirmation.Click();

            Console.WriteLine(OrderConfirmation);

            Backtohome.Click();
        }
    }
}
