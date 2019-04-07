using NUnit.Framework;
using BookingAutomation;
using BookingAutomation.Pages;
using System;

namespace BookingTests
{
    [TestFixture]
    public class ModuleTests : TestBase
    {
        [Test, Order(1)]
        public void ModuleSignInTest()
        {
            SignInPage signInPage = new SignInPage();
            signInPage.StepClickOnSignIn();
            signInPage.StepClickOnSignInWithFB();
            signInPage.StepVerifySignInFBPopUp();
            signInPage.StepClickOnSignInWithGoogle();
            signInPage.StepVerifySignInGooglePopUp();
            signInPage.StepClickOnHavingTroubleSigningInLink();
            signInPage.StepVerifyHavingTroubleSigningInLink();
            signInPage.StepClickOnBack();
            signInPage.StepClickOnCreateYourAccountLink();
            signInPage.StepVerifyCreateYourAccountLink();
            signInPage.StepClickOnBack();
            signInPage.StepEnterUsername("az.sarajevo94@gmail.com");
            signInPage.StepEnterPassword("harisamila");
            signInPage.StepVerifyWelcomePopUp();
            signInPage.StepCloseWelcomePopup();
            signInPage.StepClickOnBack();
        }

        [Test, Order(2)]
        public void ModuleAccomodiationTest()
        {
            AccommodationPage accomodiationPage = new AccommodationPage();
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
        }

        [Test, Order(3)]
        public void ModuleReservationTest()
        {
            TestPage testPage = new TestPage();
            AccommodationPage accomodiationPage = new AccommodationPage();
            accomodiationPage.StepEnterDestination("Istanbul");
            accomodiationPage.StepChoosePopularDestination();
            accomodiationPage.StepChooseFromDate(DateTime.Today.AddDays(7).ToString("yyyy/MM/dd").Replace("/", "-"));
            accomodiationPage.StepChooseToDate(DateTime.Today.AddDays(14).ToString("yyyy/MM/dd").Replace("/", "-"));
            accomodiationPage.StepClickOnSearch();
            accomodiationPage.StepSelectAccomodiation();
            testPage.StepHandleNewTab();

            ReservationPage reservationPage = new ReservationPage();
            reservationPage.StepClickOnReserve();
        }

        [Test, Order(4)]
        public void ModuleBookingTest()
        {
            TestPage testPage = new TestPage();
            AccommodationPage accomodiationPage = new AccommodationPage();
            accomodiationPage.StepEnterDestination("Istanbul");
            accomodiationPage.StepChoosePopularDestination();
            accomodiationPage.StepChooseFromDate(DateTime.Today.AddDays(7).ToString("yyyy/MM/dd").Replace("/", "-"));
            accomodiationPage.StepChooseToDate(DateTime.Today.AddDays(14).ToString("yyyy/MM/dd").Replace("/", "-"));
            accomodiationPage.StepClickOnSearch();
            accomodiationPage.StepSelectAccomodiation();
            testPage.StepHandleNewTab();

            ReservationPage reservationPage = new ReservationPage();
            reservationPage.StepClickOnReserve();

            BookingPage bookingPage = new BookingPage();
            bookingPage.StepClickOnCloseAlmostYoursPopUp();
            bookingPage.StepChooseTravelingForWork();
            bookingPage.StepSelectTitle();
            bookingPage.StepEnterFirstName("Amila");
            bookingPage.StepEnterLastName("Zimic");
            bookingPage.StepEnterEmail("az.sarajevo94@gmail.com");
            bookingPage.StepConfirmEmail("az.sarajevo94@gmail.com");
            bookingPage.StepChooseBookingFor();
            bookingPage.StepEnterFullGuestName();
            bookingPage.StepClickOnFinal();
        }

        [Test, Order(5)]
        public void ModuleFlightsTest()
        {
            TestPage testPage = new TestPage();
            FlightsPage flightsPage = new FlightsPage();
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
        }

        [Test, Order(6)]
        public void ModuleRentalCarsTest()
        {
            TestPage testPage = new TestPage();
            RentalCarsPage rentalCarsPage =  new RentalCarsPage();
            rentalCarsPage.StepNavigateToRentalCarsTab();
            testPage.StepHandleNewTab();
            rentalCarsPage.StepEnterPickUpLocation("Istanbul");
            rentalCarsPage.StepChoosePickUpLocation();
            rentalCarsPage.StepClickOnSearch();
        }

        [Test, Order(7)]
        public void ModuleAirportTaxisTest()
        {
            TestPage testPage = new TestPage();
            AirportTaxisPage airportTaxisPage = new AirportTaxisPage();
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
        }
    }
}
