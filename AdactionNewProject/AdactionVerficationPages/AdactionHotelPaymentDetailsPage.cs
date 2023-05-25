using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactionNewProject.AdactionVerficationPages
{
    public class AdactionHotelPaymentDetailsPage
    {
        WebDriver driver;
        public AdactionHotelPaymentDetailsPage(WebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        [FindsBy(How = How.CssSelector, Using = "[id='first_name']")]
        IWebElement FirstNameBox;

        [FindsBy(How = How.CssSelector, Using = "[id='last_name']")]
        IWebElement LastNameBox;


        [FindsBy(How = How.Id, Using = "address")]
        IWebElement AddressBox;

        [FindsBy(How = How.Id, Using = "cc_num")]
        IWebElement CreditCardBox;

        [FindsBy(How = How.Id, Using = "cc_cvv")]
        IWebElement CvvNumberBox;

        [FindsBy(How = How.XPath, Using = "//input[@value='Book Now']")]
        IWebElement BookNowBox;


        public void PaymentDetails(string firstName, string lastName, string Address, string ccNum)
        {
            FirstNameBox.SendKeys(firstName);

            LastNameBox.SendKeys(lastName);

            AddressBox.SendKeys(Address);

            CreditCardBox.SendKeys(ccNum);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }

        public void SelectCreditCardType()
        {
            IWebElement CreditcardType = driver.FindElement(By.CssSelector("[class='select_combobox']"));

            var selectElement = new SelectElement(CreditcardType);

            selectElement.SelectByText("American Express");

            WebDriverWait wt = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        public void CreditcardExpiryMonth()
        {
            IWebElement CreditcardExpmonth = driver.FindElement(By.CssSelector("[name='cc_exp_month']"));

            var selectElement = new SelectElement(CreditcardExpmonth);

            selectElement.SelectByText("December");

            Thread.Sleep(3000);
        }
        public void CreditCardExpiryYear()
        {
            IWebElement Creditexpyear = driver.FindElement(By.CssSelector("[name='cc_exp_year']"));

            var selectElement = new SelectElement(Creditexpyear);

            selectElement.SelectByText("2024");

            Thread.Sleep(3000);
        }
        public void VerifyCVVNumber(string cvv)
        {
            CvvNumberBox.SendKeys(cvv);

            BookNowBox.Click();

        }

        public void verifyOrderNumber()
        {
            IWebElement OrderNo = driver.FindElement(By.XPath("//input[@id='order_no']"));

            string text = OrderNo.Text;

            Console.WriteLine(text);

            Thread.Sleep(3000);
        }
    }


}
    

