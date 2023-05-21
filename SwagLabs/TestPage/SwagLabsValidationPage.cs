using SwagLabs.BaseTest;
using SwagLabs.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.TestPage
{
    [TestClass]
    public class SwagLabsValidationPage:SwagLabsBasePage
    {
        public SwagLabsLoginPage swagLabsLoginPage;

        public SwagLabsHomePage swagLabsHomePage;

        public SwagLabsItemInCartCheckoutPage swagLabsItemInCartCheckoutPage;


        [TestInitialize]
        public void Initialize()
        {
            swagLabsLoginPage=new SwagLabsLoginPage((OpenQA.Selenium.WebDriver)driver);
        }
        [TestMethod]
        
        public void SwagLabsLoginPortal()
        {
            swagLabsLoginPage.login("standard_user", "secret_sauce");
             
            Thread.Sleep(6000);
       
            swagLabsHomePage = new SwagLabsHomePage((OpenQA.Selenium.WebDriver)driver);

            swagLabsHomePage.SwaglabhomePageScroll();

            Thread.Sleep(6000);         

            swagLabsItemInCartCheckoutPage = new SwagLabsItemInCartCheckoutPage((OpenQA.Selenium.WebDriver)driver);

            swagLabsItemInCartCheckoutPage.SwagLabcartcheckout();

            Thread.Sleep(3000);

            swagLabsItemInCartCheckoutPage.VerifySwagLabCustomerDetails("sai", "Jyothi", "500072");



    }
}
}

