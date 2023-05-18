using Luma.BaseTest;
using Luma.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luma.Tests
{
    [TestClass]
    public class Validation:BaseClass
    {
        public LoginPage LoginPage;
        public SelectNewBag SelectNewBag;
        public AddressPage AddressPage;
        [TestInitialize]
        public void Initilaze()
        {
            LoginPage=new LoginPage(driver);
            SelectNewBag=new SelectNewBag((OpenQA.Selenium.WebDriver)driver);
            AddressPage=new AddressPage((OpenQA.Selenium.WebDriver)driver);

        }

        [TestMethod]
        public void errormessage()
        {
            LoginPage.login("standard_user", "secret_sauce");
            SelectNewBag.SetNewBag();
            Thread.Sleep(3000);
            AddressPage.AddressDetails("Sai", "Jyothi", "5000072");
            Thread.Sleep(5000);

        }

        
    }
}
