using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactionNewProject.ParallelExecution
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        Edge,
        Safari

    }
    public class WebDriverInit
    {
        private string _ltUserName;
        private string _ltAppKey;

        public WebDriverInit()
        {
            _ltUserName = "saijyothi98698";
            _ltAppKey = "W7uDAuLRS5AxWIJTXCqjA9CSCPq6Lspnsxmrmuc1PbwCWwIVEK";
        }

        public IWebDriver GetWebDriver(BrowserType browserType,string platform,string version,string name)
        {
            dynamic capability = GetBrowserOptions(browserType);

            if (browserType != BrowserType.Chrome && browserType!=BrowserType.Edge) 
            {
                capability.AddAdditionalCapability("platform",platform,version);
                capability.AddAdditionalCapability("version", version, true);
                capability.AddAdditionalCapability("name", name,true);
                capability.AddAdditionalCapability("build", "parallel Browser testing", true);
                capability.AddAdditionalCapability("user",_ltUserName,true);
                capability.AddAdditionalCapability("accesskey", _ltAppKey, true);
            }
            else
            {
                capability.AddAdditionalCapability("platform", platform, version);
                capability.AddAdditionalCapability("version", version, true);
                capability.AddAdditionalCapability("name", name, true);
                capability.AddAdditionalCapability("build", "parallel Browser testing", true);
                capability.AddAdditionalCapability("user", _ltUserName, true);
                capability.AddAdditionalCapability("accesskey", _ltAppKey, true);
            }

            var driver = new RemoteWebDriver(new Uri("https://"+_ltUserName+":"+_ltAppKey+"@hub.lambdatest.com/wd/hub"),capability.ToCapabilities());

            driver.Navigate().GoToUrl("http://adactinhotelapp.com/");

            driver.Manage().Window.Maximize();

            return driver;

        }

        internal void GetWebDriver()
        {
            throw new NotImplementedException();
        }

        private dynamic GetBrowserOptions(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeOptions();
                case BrowserType.Firefox:
                    return new FirefoxOptions();
                case BrowserType.Edge:
                    return new EdgeOptions();
                default:
                    throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
            }
        }
    }
}


