using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Pages
{
    public class SwagLabsLoginPage
    {
        public SwagLabsLoginPage(WebDriver driver) 
        {
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.Id, Using = "user-name")]
        IWebElement userNameText;

        [FindsBy(How = How.Name, Using = "password")]
        IWebElement passwordText;

        [FindsBy(How = How.Id, Using = "login-button")]
        IWebElement LoginButton;

        private IWebDriver driver;

        public void login(string userName,string password)
        {
            userNameText.SendKeys(userName);

            Console.WriteLine(userName);

            passwordText.SendKeys(password);

            Console.WriteLine(password);

            LoginButton.Click();



        }

    }
}
