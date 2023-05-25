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
    public class AdactionHomePage
    {
        WebDriver driver;

        public AdactionHomePage(WebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        [FindsBy(How = How.Name, Using = "Submit")]
        IWebElement SubmitButton;

        [FindsBy(How = How.XPath, Using = "//input[@name='radiobutton_0']")]
        IWebElement RadioButton;

        [FindsBy(How = How.CssSelector, Using = "[id='continue']")]
        IWebElement ContinueButton;
        public void AdactionBookHotelLocation()
        {
            IWebElement Location = driver.FindElement(By.Name("location"));

            var selectElement = new SelectElement(Location);

            selectElement.SelectByText("New York");

            Console.WriteLine(Location);
            Thread.Sleep(3000);

        }
        public void AdactionSelectHotel()
        {
            IWebElement HotelName = driver.FindElement(By.Id("hotels"));

            var selectElement = new SelectElement(HotelName);

            selectElement.SelectByText("Hotel Sunshine");

            Console.WriteLine(HotelName);
        }
        public void AdactionSelectRoomType()
        {
            IWebElement RoomType = driver.FindElement(By.CssSelector("[id='room_type']"));

            var selectElement = new SelectElement(RoomType);

            selectElement.SelectByValue("Super Deluxe");

        }
        public void AdactionSelectNumberofRooms()
        {
            IWebElement NumberRooms = driver.FindElement(By.Id("room_nos"));

            var selectElement = new SelectElement(NumberRooms);

            selectElement.SelectByIndex(2);
        }
        public void AdactionSelectCheckInandOutDate(string checkDate, string checkout)
        {
            IWebElement checkindate = driver.FindElement(By.XPath("//input[@id='datepick_in']"));

            checkindate.SendKeys(checkDate);

            IWebElement checkoutdate = driver.FindElement(By.XPath("//input[@id='datepick_out']"));

            checkoutdate.SendKeys(checkout);
            Thread.Sleep(3000);

        }
        public void AdactionSelectAdultRoom()
        {
            IWebElement AdultRoom = driver.FindElement(By.CssSelector("[id='adult_room']"));

            var selectElement = new SelectElement(AdultRoom);

            selectElement.SelectByIndex(2);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }
        public void ChildernPerRoom()
        {
            IWebElement ChildernRoom = driver.FindElement(By.CssSelector("[id='child_room']"));

            var selectElement = new SelectElement(ChildernRoom);

            selectElement.SelectByIndex(3);
        }

        public void AdactionFormSubmission()
        {
            SubmitButton.Click();
        }
        public void VerifyHotelDetails()
        {

            RadioButton.Click();

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("oldChrome.png");

            WebDriverWait wt = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            ContinueButton.Click();
        }
    }
}
    

