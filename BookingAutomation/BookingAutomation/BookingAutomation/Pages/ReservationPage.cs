using BookingAutomation.PagesSetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace BookingAutomation.Pages
{
    public class ReservationPage : PageBase
    {
        #region XPaths Region
        [FindsBy(How = How.XPath, Using = "//*[@class='property-highlights ph-icon-fill-color']//div[@class='ph-footer']/button")]
        private IWebElement ButtonReserve { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='hprt-form']/table/tbody/tr[1]/td[5]/div/label/select")]
        private IWebElement SelectRooms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='hprt-form']/table/tbody/tr[1]/td[5]/div/label/select/option[2]")]
        private IWebElement Rooms { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='hprt-table  hprt-table-long-language ']/tbody/tr/td/div[@class='hprt-block reserve-block-js']/div[@class='hprt-reservation-cta']/button")]
        private IWebElement ButtonIReserve { get; set; }
        #endregion

        #region Methods Region
        public ReservationPage StepClickOnReserve()
        {
            ButtonReserve.Click();
            Thread.Sleep(3000);
            SelectRooms.Click();
            Thread.Sleep(3000);
            Rooms.Click();
            Thread.Sleep(3000);
            ButtonIReserve.Click();
            Thread.Sleep(5000);
            return this;
        }
        #endregion
    }
}
