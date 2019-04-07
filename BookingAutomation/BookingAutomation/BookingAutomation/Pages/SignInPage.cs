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
    public class SignInPage : PageBase
    {
        #region XPaths Region
        [FindsBy(How = How.XPath, Using = "//*[@id='username']")]
        private IWebElement EnterUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        private IWebElement EnterPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='bicon bicon-aclose header-signin-prompt__close']")]
        private IWebElement ButtonCloseSignInWelcomePopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign in')]")]
        private IWebElement ButtonSignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Next')]")]
        private IWebElement ButtonNext { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-mask-closeBtn']")]
        private IWebElement ButtonCloseWelcomePopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign in with Facebook')]")]
        private IWebElement ButtonSignInWithFB { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign in with Google')]")]
        private IWebElement ButtonSignInWithGoogle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='bui_font_strong bui_color_action'][contains(text(), 'Having trouble signing in?')]")]
        private IWebElement HavingTroubleSigningInLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ap_action_link nw-link-register'][contains(text(), 'Create your account')]")]
        private IWebElement CreateYourAccountLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='header-wrapper']/a/img | //div[@class='header-wrapper']/img")]
        private IWebElement ButtonHome { get; set; }
        #endregion

        #region Methods Region
        public SignInPage StepClickOnSignIn()
        {
            ButtonCloseSignInWelcomePopup.Click();
            ButtonSignIn.Click();
            Thread.Sleep(3000);
            return this;
        }

        public SignInPage StepClickOnSignInWithFB()
        {
            ButtonSignInWithFB.Click();
            return this;
        }

        public SignInPage StepVerifySignInFBPopUp()
        {
            // Get parent (Booking.com) window handle
            string parentWindow = DriverContext.Driver.CurrentWindowHandle;
            string newFBWindow = "";
            string expectedNewFBWindowTitle = "Facebook";

            Console.WriteLine("Parnet window title: " + DriverContext.Driver.Title);

            // Store all window handles in a list
            IList<string> allWindowHandles = DriverContext.Driver.WindowHandles;

            if (allWindowHandles.Count > 1)
                Console.WriteLine("New FB window has been opened");

            //Get new window handle
            for (int i = 0; i < allWindowHandles.Count; i++)
            {
                if (allWindowHandles[i] != parentWindow)
                {
                    newFBWindow = allWindowHandles[i];
                }
            }

            // Switch to new window handle.
            DriverContext.Driver.SwitchTo().Window(newFBWindow);

            Console.WriteLine("New Window Title: " + DriverContext.Driver.Title);

            // Verify new window is in focus or not
            Assert.AreEqual(expectedNewFBWindowTitle, DriverContext.Driver.Title);
            Thread.Sleep(5000);

            // Close new window
            DriverContext.Driver.Close();

            // Get parent (Booking.com) window handle again
            DriverContext.Driver.SwitchTo().Window(parentWindow);

            Thread.Sleep(3000);
            return this;
        }

        public SignInPage StepClickOnSignInWithGoogle()
        {
            ButtonSignInWithGoogle.Click();
            return this;
        }

        public SignInPage StepVerifySignInGooglePopUp()
        {
            // Get parent (Booking.com) window handle
            string parentWindow = DriverContext.Driver.CurrentWindowHandle;
            string newGoogleWindow = "";
            string expectedNewGoogleWindowTitle = "Prijava – Google računi";

            Console.WriteLine("Parnet window title: " + DriverContext.Driver.Title);

            // Store all window handles in a list
            IList<string> allWindowHandles = DriverContext.Driver.WindowHandles;

            if (allWindowHandles.Count > 1)
                Console.WriteLine("New Google window has been opened");

            //Get new window handle
            for (int i = 0; i < allWindowHandles.Count; i++)
            {
                if (allWindowHandles[i] != parentWindow)
                {
                    newGoogleWindow = allWindowHandles[i];
                }
            }

            // Switch to new window handle
            DriverContext.Driver.SwitchTo().Window(newGoogleWindow);

            Console.WriteLine("New Window Title: " + DriverContext.Driver.Title);

            // Verify new window is in focus or not
            Assert.AreEqual(expectedNewGoogleWindowTitle, DriverContext.Driver.Title);
            Thread.Sleep(5000);

            // Close new window
            DriverContext.Driver.Close();

            // Get parent (Booking.com) window handle again
            DriverContext.Driver.SwitchTo().Window(parentWindow);

            Thread.Sleep(3000);
            return this;
        }

        public SignInPage StepClickOnHavingTroubleSigningInLink()
        {
            HavingTroubleSigningInLink.Click();
            return this;
        }

        public SignInPage StepVerifyHavingTroubleSigningInLink()
        {
            if (HavingTroubleSigningInLink.Text.Equals("Having trouble signing in?"))
                Console.WriteLine("Having Trouble Signing In Link is working!");
            Thread.Sleep(3000);
            return this;
        }

        public SignInPage StepClickOnBack()
        {
            DriverContext.Driver.Navigate().Back();
            Thread.Sleep(5000);
            return this;
        }

        public SignInPage StepClickOnCreateYourAccountLink()
        {
            CreateYourAccountLink.Click();
            return this;
        }

        public SignInPage StepVerifyCreateYourAccountLink()
        {
            if (CreateYourAccountLink.Text.Equals("Create your account"))
                Console.WriteLine("Create Your Account Link is working!");
            Thread.Sleep(3000);
            return this;
        }

        public SignInPage StepEnterUsername(string username)
        {
            EnterUsername.SendKeys(username);
            ButtonNext.Click();
            return this;
        }

        public SignInPage StepEnterPassword(string password)
        {
            Thread.Sleep(3000);
            EnterPassword.Click();
            EnterPassword.Clear();
            EnterPassword.SendKeys(password);
            ButtonSignIn.Click();
            Thread.Sleep(5000);
            return this;
        }

        public SignInPage StepVerifyWelcomePopUp()
        {
            var welcomePopUpElement = DriverContext.Driver.FindElement(By.XPath("//*[@id='wl252-modal-name']/div/h1"));

            if (welcomePopUpElement.Text.Contains("Welcome to Booking.com") && !string.IsNullOrEmpty(welcomePopUpElement.Text))
                Console.WriteLine("Accomodiation page is displayed!");

            Console.WriteLine("Accomodiation page is not displayed!");
            return this;
        }

        public SignInPage StepCloseWelcomePopup()
        {
            ButtonCloseWelcomePopup.Click();
            Thread.Sleep(2000);
            return this;
        }

        public SignInPage StepClickOnHomeButton()
        {
            ButtonHome.Click();
            Thread.Sleep(5000);
            return this;
        }
        #endregion
    }
}
