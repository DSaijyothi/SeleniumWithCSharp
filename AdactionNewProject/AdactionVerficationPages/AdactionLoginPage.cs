using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactionNewProject.AdactionVerficationPages
{
    public class AdactionLoginPage
    {
        public AdactionLoginPage(WebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Name, Using = "username")]
        IWebElement AdactionUsernameBox;

        [FindsBy(How = How.Id, Using = "password")]
        IWebElement AdactionPasswordBox;

        [FindsBy(How = How.CssSelector, Using = "[class='login_button']")]
        IWebElement AdactionLoginButton;


        public void AdactionLoginPageEntry(string username, string password)
        {
            AdactionUsernameBox.SendKeys(username);

            AdactionPasswordBox.SendKeys(password);

            AdactionLoginButton.Click();
        }
    }
}

    

