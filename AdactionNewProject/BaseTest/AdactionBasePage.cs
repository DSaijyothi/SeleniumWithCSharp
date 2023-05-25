using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactionNewProject.BaseTest
{
   
        [TestClass]
        public class AdactionBasePage
        {
            public static WebDriver driver;

            [TestInitialize]
            public void OpenAdactionApplication()
            {
                driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://adactinhotelapp.com/");

                driver.Manage().Window.Maximize();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            }
            [TestCleanup]
            public void CloseAdactionApplication()
            {

                driver.Dispose();

            }
        }
    }


