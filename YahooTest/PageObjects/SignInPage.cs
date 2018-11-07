using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace YahooTest.PageObjects
{
    public class SignInPage : BaseForm
    {
        private readonly BaseElement _passwordField = new BaseElement(By.XPath("//*[@id='login-passwd']"));
        [FindsBy(How = How.XPath, Using = "//input[@id='login-username']")]
        private IWebElement loginField;
        public void enterEmail(string _email)
        {
            this.loginField.SendKeys(_email);
            this.loginField.Submit();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='login-passwd']")]
        private IWebElement passwordField;
        public void enterPassword(string _password)
        {
            Browser.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            this.passwordField.SendKeys(_password);
            this.passwordField.SendKeys(Keys.Enter);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Aleksei')]")]
        private IWebElement userName;
        public void ValidateUser(string expectedName)
        {
            Assert.IsTrue(userName.Text.Contains(expectedName));
        }
    }
}
