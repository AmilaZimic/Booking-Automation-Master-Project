using OpenQA.Selenium;

namespace BookingAutomation.PageSetUp
{
    public class DriverContext
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
    }
}
