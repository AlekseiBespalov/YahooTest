using NUnit.Framework;

namespace YahooTest
{
    public class BaseTest
    {
        protected static Browser Browser;

        [OneTimeSetUp]
        public void SetUp()
        {
            Browser = Browser.Instance;
            Browser.WindowMaximise();
            Browser.NavigateTo(Configuration.StartUrl);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Browser.Quit();
        }
    }
}
