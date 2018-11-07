using NUnit.Framework;
using YahooTest.PageObjects;

namespace YahooTest
{
    [TestFixture]
    public class YahooTest : BaseTest
    {
        static string _email = "abespalov@yahoo.com";
        static string _password = "ErhJE154";
        static string _message = "Message";
        static string _recipientEmail = "bespaloww2014@gmail.com";
        static string _mailSubject = "Selenium test";
        static string _userName = "Aleksei";

        [Test, Order(1)]
        public void YahooLogin()
        {
            HomePage homePage = new HomePage();
            SignInPage signInPage = new SignInPage();

            homePage.goToSignInPage();
            signInPage.enterEmail(_email);
            signInPage.enterPassword(_password);
            signInPage.ValidateUser(_userName);
        }

        [Test, Order(2)]
        public void YahooWriteMessage()
        {
            //YahooLogin();
            HomePage homePage = new HomePage();
            MailPage mailPage = new MailPage();

            homePage.goToMailPage();
            mailPage.PressCompose();
            mailPage.FillRecipientField(_recipientEmail);
            mailPage.FillSubjectField(_mailSubject);
            mailPage.FillTextField(_message);

            mailPage.GotToDraftFolder();
            mailPage.ValidateSentMessage(_userName);
        }

        [Test, Order(3)]
        public void YahooSendMessage()
        {
            //YahooLogin();
            MailPage mailPage = new MailPage();

            mailPage.GotToDraftFolder();
            mailPage.PressLastDraft();
            mailPage.PressSendButton();
            mailPage.ValidateSentMessage(_userName);
        }
    }
}
