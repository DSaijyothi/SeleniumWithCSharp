using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactionNewProject.AdactionVerficationPages
{
    public class AdactionTitleVerificationPage
    {
        WebDriver driver;

        public AdactionTitleVerificationPage(WebDriver driver)
        {
            this.driver = driver;
        }
        public void TitleVerification()
        {
            string actualMessage = driver.FindElement(By.XPath("//td[text()='Welcome to Adactin Group of Hotels']")).Text;

            string message = driver.FindElement(By.XPath("//td[@class='welcome_menu'][1]")).Text;

            Assert.AreEqual(message, actualMessage, "Assert Failed");

            Console.WriteLine(actualMessage);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }
    }
}
    

