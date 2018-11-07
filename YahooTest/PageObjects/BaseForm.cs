using OpenQA.Selenium.Support.PageObjects;

namespace YahooTest.PageObjects
{
    public class BaseForm
    {
        public BaseForm()
        {
            PageFactory.InitElements(Browser.GetDriver(), this);
        }
    }
}