using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luma.BaseTest
{
    [TestClass]

    public class BaseClass
    {
        public IWebDriver driver;
        [TestInitialize]
        public void OpenApplication()
        {
            driver=new ChromeDriver();
            driver=new FirefoxDriver();
            driver=new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);


        }
        [TestCleanup]
        public void CleanSession()
        {
            driver.Dispose();
        }
    }
}
