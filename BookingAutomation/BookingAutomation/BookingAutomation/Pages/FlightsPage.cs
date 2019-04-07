using BookingAutomation.PageSetUp;
using BookingAutomation.PagesSetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;

namespace BookingAutomation.Pages
{
    public class FlightsPage : PageBase
    {
        #region XPaths Region
        [FindsBy(How = How.XPath, Using = "//div[@class='cross-product-bar__wrapper ']/a/span[contains(text(), 'Flights')]")]
        private IWebElement NavigateToFlightsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='displayCatBlock']//span/label[@title='One-way']")]
        private IWebElement OneWay { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='displayCatBlock']//span/label[@title='Multi-city']")]
        private IWebElement MultiCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='displayCatBlock']//span/label[@title='Round-trip']")]
        private IWebElement RoundTrip { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='inputWrapper']/input[@value='Dubrovnik (DBV)']")]
        private IWebElement EnterFromWhere { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@role='listbox']/li")]
        private IWebElement ChooseFromDestination { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='fieldBlock airportBlock destinationBlock']/input")]
        private IWebElement EnterToWhere { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@role='listbox']/li[@data-short-name='Istanbul (IST)']")]
        private IWebElement ChooseToDestination { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='search-form-inner']//div[@class='col col-button right']")]
        private IWebElement ButtonSearch { get; set; }
        #endregion

        #region Methods Region
        public FlightsPage StepNavigateToFlightsTab()
        {
            NavigateToFlightsTab.Click();
            Thread.Sleep(2000);
            return this;
        }

        public FlightsPage StepNavigateToOneWay()
        {
            OneWay.Click();
            Thread.Sleep(5000);
            return this;
        }

        public FlightsPage StepNavigateToMultiCity()
        {
            MultiCity.Click();
            Thread.Sleep(5000);
            return this;
        }

        public FlightsPage StepNavigateToRoundTrip()
        {
            RoundTrip.Click();
            Thread.Sleep(5000);
            return this;
        }

        public FlightsPage StepEnterFromWhere(string fromDestination)
        {
            EnterFromWhere.Clear();
            Thread.Sleep(2000);
            EnterFromWhere.SendKeys(fromDestination);
            Thread.Sleep(2000);
            return this;
        }

        public FlightsPage StepChooseFromDestination()
        {
            ChooseFromDestination.Click();
            Thread.Sleep(2000);
            return this;
        }

        public FlightsPage StepEnterToWhere(string toDestination)
        {
            EnterToWhere.Clear();
            Thread.Sleep(2000);
            EnterToWhere.SendKeys(toDestination);
            Thread.Sleep(2000);
            return this;
        }

        public FlightsPage StepChooseToDestination()
        {
            ChooseToDestination.Click();
            Thread.Sleep(2000);
            return this;
        }

        public FlightsPage StepChooseFromDate(string fromDate)
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//div[@class='weeks']//div[@aria-label='{0}']", fromDate))).Click();
            Thread.Sleep(2000);
            return this;
        }

        public FlightsPage StepChooseToDate(string toDate)
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//div[@class='weeks']//div[@aria-label='{0}']", toDate))).Click();
            Thread.Sleep(2000);
            return this;
        }

        public FlightsPage StepClickOnSearch()
        {
            ButtonSearch.Click();
            Thread.Sleep(5000);
            return this;
        }
        #endregion
    }
}
