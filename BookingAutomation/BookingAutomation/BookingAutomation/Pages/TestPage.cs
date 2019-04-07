using BookingAutomation.PageSetUp;
using BookingAutomation.PagesSetUp;
using System;
using System.Collections.Generic;
using System.Threading;

namespace BookingAutomation.Pages
{
    public class TestPage : PageBase
    {
        string parentTab = DriverContext.Driver.CurrentWindowHandle;
        string newTab = "";

        public TestPage StepHandleNewTab()
        {
            // Store all window handles in a list
            IList<string> allTabsHandles = DriverContext.Driver.WindowHandles;

            if (allTabsHandles.Count > 1)
                Console.WriteLine("New Google window has been opened");

            //Get new window handle
            for (int i = 0; i < allTabsHandles.Count; i++)
            {
                if (allTabsHandles[i] != parentTab)
                {
                    newTab = allTabsHandles[i];
                }
            }

            // Switch to new window handle
            DriverContext.Driver.SwitchTo().Window(newTab);
            Thread.Sleep(10000);
            Console.WriteLine("New tab title: " + DriverContext.Driver.Title);
            return this;
        }

        public TestPage StepCloseNewTab()
        {
            // Get parent (Booking.com) tab handle again
            DriverContext.Driver.SwitchTo().Window(parentTab);
            Thread.Sleep(10000);
            return this;
        }
    }
}
