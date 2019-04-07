using NUnit.Framework;
using BookingAutomation;
using BookingAutomation.Pages;
using System;

namespace BookingTests
{
    [TestFixture]
    public class SmokeTests : TestBase
    {
        [Test]
        public void SmokeTest()
        {
            #region Instance of Classes
            TestPage testPage = new TestPage();
            SignInPage signInPage = new SignInPage();
            AccommodationPage accomodiationPage = new AccommodationPage();
            ReservationPage reservationPage = new ReservationPage();
            BookingPage bookingPage = new BookingPage();
            FlightsPage flightsPage = new FlightsPage();
            RentalCarsPage rentalCarsPage = new RentalCarsPage();
            AirportTaxisPage airportTaxisPage = new AirportTaxisPage();
            #endregion

            #region Test Steps
            /** Steps from Module SignIn */
            signInPage.StepClickOnSignIn();
            signInPage.StepEnterUsername("az.sarajevo94@gmail.com");
            signInPage.StepEnterPassword("harisamila");
            signInPage.StepVerifyWelcomePopUp();
            signInPage.StepCloseWelcomePopup();

            /** Steps from Module Accomodiation */
            accomodiationPage.StepEnterDestination("Istanbul");
            accomodiationPage.StepChoosePopularDestination();
            accomodiationPage.StepChooseFromDate(DateTime.Today.AddDays(7).ToString("yyyy/MM/dd").Replace("/", "-"));
            accomodiationPage.StepChooseToDate(DateTime.Today.AddDays(14).ToString("yyyy/MM/dd").Replace("/", "-"));
            accomodiationPage.StepClickOnSearch();
            accomodiationPage.StepChooseStarRating("3");
            accomodiationPage.StepChooseOnlyAvailableProperties();
            accomodiationPage.StepChooseReviewScore("70");
            accomodiationPage.StepNavigateToTab("Distance From Downtown");
            accomodiationPage.StepNavigateToTab("Star rating and price");
            accomodiationPage.StepNavigateToTab("Stars");
            accomodiationPage.StepNavigateToTab("Review Score & Price");
            accomodiationPage.StepNavigateToTab("Price (lowest first)");
            accomodiationPage.StepNavigateToTab("Our Top Picks");
            accomodiationPage.StepSelectAccomodiation();
            testPage.StepHandleNewTab();

            /** Steps from Module Reservation */
            reservationPage.StepClickOnReserve();

            /** Steps from Module Booking */
            //bookingPage.StepClickOnCloseAlmostYoursPopUp();
            bookingPage.StepChooseTravelingForWork();
            bookingPage.StepSelectTitle();
            bookingPage.StepEnterFirstName("Amila");
            bookingPage.StepEnterLastName("Zimic");
            bookingPage.StepVerifyEmail("az.sarajevo94@gmail.com");
            bookingPage.StepVerifyConfirmEmail("az.sarajevo94@gmail.com");
            bookingPage.StepChooseBookingFor();
            bookingPage.StepEnterFullGuestName();
            bookingPage.StepClickOnFinal();
            testPage.StepCloseNewTab();
            signInPage.StepClickOnHomeButton();

            /** Steps from Module Flisghts */
            flightsPage.StepNavigateToFlightsTab();
            testPage.StepHandleNewTab();
            flightsPage.StepNavigateToOneWay();
            flightsPage.StepNavigateToMultiCity();
            flightsPage.StepNavigateToRoundTrip();
            flightsPage.StepEnterFromWhere("Sarajevo");
            flightsPage.StepChooseFromDestination();
            flightsPage.StepEnterToWhere("Istanbul");
            flightsPage.StepChooseToDestination();
            flightsPage.StepChooseFromDate(DateTime.Today.AddDays(7).ToString("MMMM dd"));
            flightsPage.StepChooseToDate(DateTime.Today.AddDays(14).ToString("MMMM dd"));
            flightsPage.StepClickOnSearch();
            testPage.StepHandleNewTab();
            testPage.StepCloseNewTab();

            /** Steps from Module AirportTaxis */
            airportTaxisPage.StepNavigateToAirportTaxisTab();
            testPage.StepHandleNewTab();
            airportTaxisPage.StepEnterPickUpLocation("Istanbul");
            airportTaxisPage.StepChoosePickUpLocation();
            airportTaxisPage.StepEnterDropOffLocation("Blue Mosque");
            airportTaxisPage.StepChooseDropOffLocation();
            airportTaxisPage.StepClickOnSearch();
            airportTaxisPage.StepClickOnBookTaxi();
            airportTaxisPage.StepSelectTitle();
            airportTaxisPage.StepEnterFirstName("Amila");
            airportTaxisPage.StepEnterLastName("Zimic");
            airportTaxisPage.StepEnterEmail("az.sarajevo94@gmail.com");
            airportTaxisPage.StepConfirmEmail("az.sarajevo94@gmail.com");
            airportTaxisPage.StepChooseCountry();
            airportTaxisPage.StepEnterMobileNumber("62253119");
            airportTaxisPage.StepClickOnContinueToBook();
            #endregion
        }
    }
}
