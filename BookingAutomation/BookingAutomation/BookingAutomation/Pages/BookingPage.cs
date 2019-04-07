using BookingAutomation.PageSetUp;
using BookingAutomation.PagesSetUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace BookingAutomation.Pages
{
    public class BookingPage : PageBase
    {
        #region XPaths Region
        [FindsBy(How = How.XPath, Using = "//*[@id='bp_travel_purpose_leasure']")]
        private IWebElement ChooseTravelingForWork { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='booker_title']")]
        private IWebElement SelectTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='booker_title']/option[3]")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='firstname']")]
        private IWebElement EnterFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='lastname']")]
        private IWebElement EnterLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]
        private IWebElement EnterEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='email_confirm']")]
        private IWebElement ConfirmEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='notstayer_false']")]
        private IWebElement ChooseBookingFor { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='guest-details-holder']/tbody/tr/td[@class='guest-name-details just-guest-name']/input")]
        private IWebElement EnterFullGuestName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='uf_addon_name']/label[contains(text(),'Breakfast')][1]")]
        private IWebElement CheckBreakfastExist { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='uf_addons_container']//div/input[@class='addon_checkbox ']")]
        private IWebElement CheckBreakfast { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='uf_addon property-airport-shuttle  ']//label[contains(text(),' interested in requesting an airport shuttle')]")]
        private IWebElement CheckAirportShuttleExists { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='uf_addon property-airport-shuttle  ']/div/input[@name='airport_shuttle_please']")]
        private IWebElement CheckAirportShuttle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='uf_addon_name longer_addon_desc']/label[contains(text(),' interested in renting a car')]")]
        private IWebElement CheckRentACarExists { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='uf_checkbox']/input[@name='interested_car_rentals']")]
        private IWebElement CheckRentACar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='bookForm']//div/button[contains(text(), 'Next: Final details')]")]
        private IWebElement ButtonFinal { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='modal-mask-closeBtn']")]
        private IWebElement ButtonCloseAlmostYoursPopUp { get; set; }
        #endregion

        #region Methods Region
        public BookingPage StepChooseTravelingForWork()
        {
            ChooseTravelingForWork.Click();
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepSelectTitle()
        {
            SelectTitle.Click();
            Title.Click();
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepEnterFirstName(string firstname)
        {
            EnterFirstName.SendKeys(firstname);
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepEnterLastName(string lastname)
        {
            EnterLastName.SendKeys(lastname);
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepEnterEmail(string email)
        {
            EnterEmail.SendKeys(email);
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepVerifyEmail(string email)
        {
            Assert.AreEqual(EnterEmail.GetAttribute("value"), email);
            Console.WriteLine("Email address is correct!");
            Thread.Sleep(3000);
            return this;
        }

        public BookingPage StepConfirmEmail(string confirmEmail)
        {
            ConfirmEmail.SendKeys(confirmEmail);
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepVerifyConfirmEmail(string confirmEmail)
        {
            Assert.AreEqual(ConfirmEmail.GetAttribute("value"), confirmEmail);
            Console.WriteLine("ConfirmEmail address is correct!");
            Thread.Sleep(3000);
            return this;
        }

        public BookingPage StepChooseBookingFor()
        {
            ChooseBookingFor.Click();
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepEnterFullGuestName()
        {
            EnterFullGuestName.Click();
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepCheckBreakfast()
        {
            CheckBreakfast.Click();
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepCheckAirportShuttle()
        {
            if (CheckAirportShuttleExists.Displayed)
                CheckAirportShuttle.Click();
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepCheckRentACar()
        {
            if (CheckRentACarExists.Displayed)
                CheckRentACar.Click();
            Thread.Sleep(2000);
            return this;
        }

        public BookingPage StepClickOnFinal()
        {
            ButtonFinal.Click();
            Thread.Sleep(10000);
            return this;
        }

        public BookingPage StepClickOnCloseAlmostYoursPopUp()
        {
            Thread.Sleep(10000);
            ButtonCloseAlmostYoursPopUp.Click();
            Thread.Sleep(3000);
            return this;
        }
        #endregion
    }
}
