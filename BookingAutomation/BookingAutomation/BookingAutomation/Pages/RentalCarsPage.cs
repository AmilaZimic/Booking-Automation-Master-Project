using BookingAutomation.PageSetUp;
using BookingAutomation.PagesSetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;

namespace BookingAutomation.Pages
{
    public class RentalCarsPage : PageBase
    {
        #region XPaths Region
        [FindsBy(How = How.XPath, Using = "//div[@class='cross-product-bar__wrapper ']/a/span[contains(text(), 'Car Rentals')]")]
        private IWebElement NavigateToRentalCarsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='xp__fieldset rentalcars']/div[@data-visible='rentalcars']//input[@type='search'] | //input[@id='ftsAutocomplete']")]
        private IWebElement EnterPickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@aria-label='List of suggested destinations ']/li[@data-i='1'] | (//ul[@role='listbox']/li)[1]")]
        private IWebElement ChoosePickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='xp__button'] | //fieldset[@id='btn-fieldset']/input")]
        private IWebElement ButtonSearch { get; set; }
        #endregion

        #region Methods Region
        public RentalCarsPage StepNavigateToRentalCarsTab()
        {
            NavigateToRentalCarsTab.Click();
            Thread.Sleep(2000);
            return this;
        }

        public RentalCarsPage StepEnterPickUpLocation(string pickUpLocation)
        {
            EnterPickUpLocation.Click();
            Thread.Sleep(2000);
            EnterPickUpLocation.SendKeys(pickUpLocation);
            Thread.Sleep(2000);
            return this;
        }

        public RentalCarsPage StepChoosePickUpLocation()
        {
            ChoosePickUpLocation.Click();
            Thread.Sleep(2000);
            return this;
        }

        public RentalCarsPage StepClickOnSearch()
        {
            ButtonSearch.Click();
            Thread.Sleep(15000);
            return this;
        }
        #endregion
    }
}
