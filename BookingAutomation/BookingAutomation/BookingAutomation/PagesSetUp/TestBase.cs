using BookingAutomation.PageSetUp;
using NUnit.Framework;

namespace BookingAutomation
{
    [TestFixture]
    public class TestBase
    {
        string url = "https://booking.com";

        [SetUp]
        public void InitializeBrowser()
        {
            BrowserInitialize.ChromeBrowserInitialize(url);
        }

        [TearDown]
        public void CloseBrowser()
        {
            DriverContext.Driver.Quit();
        }
    }
}
