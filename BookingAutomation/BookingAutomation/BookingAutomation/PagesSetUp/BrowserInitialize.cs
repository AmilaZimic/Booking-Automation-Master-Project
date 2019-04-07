using BookingAutomation.PageSetUp;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace BookingAutomation
{
    public class BrowserInitialize
    {
        public static void ChromeBrowserInitialize(string url)
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);
            DriverContext.Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        public static void FirefoxBrowserInitialize(string url)
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);
        }
    }
}
