using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactionNewProject.AdactionVerficationPages
{
    public class AdactionCheckMyBookedHotelListcs
    {
        WebDriver driver;

        public AdactionCheckMyBookedHotelListcs(WebDriver driver)
        {
            PageFactory.InitElements(driver, this);

            this.driver = driver;
        }
        [FindsBy(How = How.XPath, Using = "//a[text()='Booked Itinerary']")]
        IWebElement CheckBookItinerary;

        public void Adactioncheckhtlbookinglist()
        {
            CheckBookItinerary.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("newChrome.png");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);



        }
    }
}
    

