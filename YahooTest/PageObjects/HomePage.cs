using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace YahooTest.PageObjects
{
    class HomePage : BaseForm
    {
        private const string StartUrl = "https://yahoo.com";
        private readonly BaseElement signInButton = new BaseElement(By.XPath("//*[@id='uh-signin']"));
        public void goToSignInPage()
        {
            this.signInButton.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#uh-mail-link")]
        private IWebElement emailButton;
        public void goToMailPage()
        {
            this.emailButton.Click();
        }

        public void goToHomePage()
        {
            Browser.GetDriver().Navigate().GoToUrl("https://www.yahoo.com");
        }
    }
}
