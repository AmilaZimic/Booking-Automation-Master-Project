using BookingAutomation.PageSetUp;
using BookingAutomation.PagesSetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace BookingAutomation.Pages
{
    public class AccommodationPage : PageBase
    {
        #region XPaths Region
        [FindsBy(How = How.XPath, Using = "//*[@id='ss']")]
        private IWebElement EnterDestination { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='frm']//ul/li[contains(.,'Popular')]")]
        private IWebElement PopularDestination { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='sb-searchbox__button  ']")]
        private IWebElement ButtonSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='hotellist_inner']//div[@class='sr_rooms_table_block clearfix']//div/a[@class='b-button b-button_primary sr_cta_button']/span)[1]")]
        private IWebElement FirstAccomodiation { get; set; }
        #endregion

        #region Methods Region
        public AccommodationPage StepEnterDestination(string destination)
        {
            EnterDestination.Clear();
            EnterDestination.SendKeys(destination);
            Thread.Sleep(2000);
            return this;
        }

        public AccommodationPage StepChoosePopularDestination()
        {
            PopularDestination.Click();
            Thread.Sleep(2000);
            return this;
        }

        public AccommodationPage StepChooseFromDate(string fromDate)
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//*[@data-date='{0}']", fromDate))).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AccommodationPage StepChooseToDate(string toDate)
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//*[@data-date='{0}']", toDate))).Click();
            Thread.Sleep(2000);
            return this;
        }

        public AccommodationPage StepClickOnSearch()
        {
            ButtonSearch.Click();
            return this;
        }

        public AccommodationPage StepChooseStarRating(string stars)
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//*[@id='filter_class']//span[contains(text(),'{0} stars')]", stars))).Click();
            Thread.Sleep(5000);
            return this;
        }

        public AccommodationPage StepChooseDistanceFromCityCenter(string distance)
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//*[@id='filter_distance']//a[@data-id='distance-{0}']", distance))).Click();
            Thread.Sleep(5000);
            return this;
        }

        public AccommodationPage StepChooseOnlyAvailableProperties()
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//*[@id='filter_out_of_stock']//a[@data-id='oos-1']"))).Click();
            Thread.Sleep(5000);
            return this;
        }

        public AccommodationPage StepChooseReviewScore(string reviewScore)
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//*[@id='filter_review']//a[@data-id='review_score-{0}']", reviewScore))).Click();
            Thread.Sleep(5000);
            return this;
        }

        public AccommodationPage StepNavigateToTab (string navigateOption)
        {
            DriverContext.Driver.FindElement(By.XPath(string.Format("//ul[@class='sort_option_list']/li/a[contains(text(),'{0}')]", navigateOption))).Click();
            Thread.Sleep(5000);

            if (navigateOption.Equals("Stars"))
            {
                DriverContext.Driver.FindElement(By.XPath(string.Format("//ul[@class='sort_option_sublist']/li/a[contains(text(),'stars [1 to 5]')]"))).Click();
                Thread.Sleep(5000);
            }

            return this;
        }

        public AccommodationPage StepSelectAccomodiation()
        {
            FirstAccomodiation.Click();
            Thread.Sleep(10000);
            return this;
        }
        #endregion
    }
}
