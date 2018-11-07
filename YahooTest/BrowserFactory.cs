using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace YahooTest
{
    public class BrowserFactory
    {
        public enum BrowserType
        {
            Chrome,
            Firefox,
            RemoteFirefox,
            RemoteChrome
        }

        public static IWebDriver GetDriver(BrowserType type, int timeOutSec)
        {
            IWebDriver driver = null;

            switch (type)
            {
                case BrowserType.Chrome:
                    {
                        var service = ChromeDriverService.CreateDefaultService();
                        var option = new ChromeOptions();
                        option.AddArgument("disable-infobars");
                        driver = new ChromeDriver(service, option, TimeSpan.FromSeconds(timeOutSec));
                        break;
                    }
                case BrowserType.Firefox:
                    {
                        var service = FirefoxDriverService.CreateDefaultService();
                        var options = new FirefoxOptions();
                        options.SetPreference("permissions.default.image", 2);
                        options.AddArguments("-private");
                        driver = new FirefoxDriver(service, options);
                        break;
                    }
                case BrowserType.RemoteFirefox:
                    {
                        var option = new FirefoxOptions();
                        option.AddArgument("disable-infobars");
                        option.AddArgument("--no-sandbox");
                        driver = new RemoteWebDriver(new Uri("http://null"), option.ToCapabilities());
                        break;

                    }
                case BrowserType.RemoteChrome:
                    {
                        var option = new ChromeOptions();
                        option.AddArgument("disable-infobars");
                        option.AddArgument("--no-sandbox");
                        driver = new RemoteWebDriver(new Uri("http://null"), option.ToCapabilities());
                        break;
                    }
            }
            return driver;
        }
    }
}
