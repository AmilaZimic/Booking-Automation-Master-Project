using BookingAutomation.PageSetUp;
using BookingAutomation.PagesSetUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;

namespace BookingAutomation.Pages
{
    public class AirportTaxisPage : PageBase
    {
        #region XPaths Region
        [FindsBy(How = How.XPath, Using = "//div[@class='cross-product-bar__wrapper ']/a/span[contains(text(), 'Airport Taxis')]")]
        private IWebElement NavigateToAirportTaxisTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='rw-poi-finder']/input[@id='pickupLocation']")]
        private IWebElement EnterPickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@role='listbox']//li/button/div/h4[contains(text(), 'Istanbul Airport (ISL)')]")]
        private IWebElement ChoosePickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='rw-poi-finder']/input[@id='dropoffLocation']")]
        private IWebElement EnterDropOffLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@role='listbox']//li/button/div/h4[contains(text(), 'Sultan Ahmet Mahallesi, Blue Mosque, Atmeydanı Caddesi, Fatih/Istanbul, Turkey')]")]
        private IWebElement ChooseDropOffLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@name='searchButton']")]
        private IWebElement ButtonSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-test='rw-search-result--0']/div[@class='rw-search-result__aside']/a")]
        private IWebElement ButtonBookTaxi { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='title']")]
        private IWebElement SelectTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='title']/option[3]")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='firstname']")]
        private IWebElement EnterFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='lastname']")]
        private IWebElement EnterLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='emailaddress']")]
        private IWebElement EnterEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='verifyemailaddress']")]
        private IWebElement ConfirmEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='phone-input__link']")]
        private IWebElement Flag { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='phone-input_countries']/li/button[contains(text(), 'Bosnia and Herzegovina (+387)')]")]
        private IWebElement ChooseFlag { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='tel']")]
        private IWebElement MobileNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='rw-form__submit']/span/button")]
        private IWebElement ButtonContinueToBook { get; set; }
        #endregion

        #region Methods Region

        public AirportTaxisPage StepNavigateToAirportTaxisTab()
        {
            NavigateToAirportTaxisTab.Click();
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepEnterPickUpLocation(string pickUpLocation)
        {
            EnterPickUpLocation.Click();
            Thread.Sleep(2000);
            EnterPickUpLocation.SendKeys(pickUpLocation);
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepChoosePickUpLocation()
        {
            ChoosePickUpLocation.Click();
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepEnterDropOffLocation(string pickUpLocation)
        {
            EnterDropOffLocation.Click();
            Thread.Sleep(2000);
            EnterDropOffLocation.SendKeys(pickUpLocation);
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepChooseDropOffLocation()
        {
            ChooseDropOffLocation.Click();
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepClickOnSearch()
        {
            ButtonSearch.Click();
            Thread.Sleep(15000);
            return this;
        }

        public AirportTaxisPage StepClickOnBookTaxi()
        {
            ButtonBookTaxi.Click();
            Thread.Sleep(10000);
            return this;
        }

        public AirportTaxisPage StepSelectTitle()
        {
            SelectTitle.Click();
            Title.Click();
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepEnterFirstName(string firstname)
        {
            EnterFirstName.SendKeys(firstname);
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepEnterLastName(string lastname)
        {
            EnterLastName.SendKeys(lastname);
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepEnterEmail(string email)
        {
            EnterEmail.SendKeys(email);
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepVerifyEmail(string email)
        {
            Assert.AreEqual(EnterEmail.GetAttribute("value"), email);
            Console.WriteLine("Email address is correct!");
            Thread.Sleep(3000);
            return this;
        }

        public AirportTaxisPage StepConfirmEmail(string confirmEmail)
        {
            ConfirmEmail.SendKeys(confirmEmail);
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepVerifyConfirmEmail(string confirmEmail)
        {
            Assert.AreEqual(ConfirmEmail.GetAttribute("value"), confirmEmail);
            Console.WriteLine("ConfirmEmail address is correct!");
            Thread.Sleep(3000);
            return this;
        }

        public AirportTaxisPage StepChooseCountry()
        {
            Flag.Click();
            Thread.Sleep(1000);
            ChooseFlag.Click();
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepEnterMobileNumber(string mobileNumber)
        {
            MobileNumber.Clear();
            Thread.Sleep(1000);
            MobileNumber.SendKeys(mobileNumber);
            Thread.Sleep(2000);
            return this;
        }

        public AirportTaxisPage StepClickOnContinueToBook()
        {
            ButtonContinueToBook.Click();
            Thread.Sleep(10000);
            return this;
        }
        #endregion
    }
}
