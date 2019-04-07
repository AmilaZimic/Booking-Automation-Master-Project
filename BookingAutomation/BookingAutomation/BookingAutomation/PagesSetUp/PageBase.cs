using BookingAutomation.PageSetUp;
using OpenQA.Selenium.Support.PageObjects;

namespace BookingAutomation.PagesSetUp
{
    public abstract class PageBase
    {
        public PageBase()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
