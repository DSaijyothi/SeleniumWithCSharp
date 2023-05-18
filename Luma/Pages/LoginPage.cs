using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.Network;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luma.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "user-name")]
            private IWebElement UserInputBox;

        [FindsBy(How=How.Name,Using = "password")]
        private IWebElement PasswordInputBox;

        [FindsBy(How=How.Id,Using = "login-button")]
        private IWebElement LogInButton;

        public void login(string UserName, string Password)
        {
            UserInputBox.SendKeys(UserName);
            PasswordInputBox.SendKeys(Password);
            LogInButton.Click();
            Thread.Sleep(3000);
        }



    }
}
