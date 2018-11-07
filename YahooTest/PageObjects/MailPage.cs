using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace YahooTest.PageObjects
{
    class MailPage : BaseForm
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Compose')]")]
        private IWebElement composeButton;
        public void PressCompose()
        {
            this.composeButton.Click();
        }

        [FindsBy(How = How.Id, Using = "message-to-field")]
        private IWebElement recipientField;
        public void FillRecipientField(string _recipientEmail)
        {
            this.recipientField.Click();
            this.recipientField.SendKeys(_recipientEmail);
        }

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Subject']")]
        private IWebElement subjectField;
        public void FillSubjectField(string _mailSubject)
        {
            this.subjectField.Click();
            this.subjectField.SendKeys(_mailSubject);
        }

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Message body']")]
        private IWebElement textField;
        public void FillTextField(string _message)
        {
            this.textField.Click();
            this.textField.SendKeys(_message);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Drafts')]")]
        private IWebElement draftFolder;
        public void GotToDraftFolder()
        {
            this.draftFolder.Click();
        }

        [FindsBy(How = How.XPath, Using = "//a[@data-test-id='message-list-item']")]
        private IWebElement lastDraft;
        public void PressLastDraft()
        {
            this.lastDraft.Click();
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Send')]")]
        private IWebElement sendButton;
        public void PressSendButton()
        {
            this.sendButton.Click();
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Aleksei')]")]
        private IWebElement sentRecipient;

        public void ValidateSentMessage(string expectedUserName)
        {
            Assert.IsTrue(sentRecipient.Text.Contains(expectedUserName));
        }
    }
}
