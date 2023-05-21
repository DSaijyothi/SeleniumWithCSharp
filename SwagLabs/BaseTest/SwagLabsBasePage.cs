using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SwagLabs.BaseTest
{
    public class SwagLabsBasePage
    {
        public IWebDriver driver;

        [TestInitialize]
        public void OpenSwapLabsApplication()
        {
            string ActualResult;

            string ExpectedResult = "Swag Labs";

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            driver.Manage().Window.Maximize();
            ActualResult = driver.Title;

            if (ActualResult.Contains(ExpectedResult))
            {
                Console.WriteLine("Test Case Passed");

            }
            else
            {
                Console.WriteLine("Test Case Failed");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [TestCleanup]
        public void CloseSwapLabsApplication()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

    }
}

