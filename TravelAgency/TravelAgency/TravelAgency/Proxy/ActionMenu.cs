using System;
using TravelAgency.Factory.Types;

namespace TravelAgency.Proxy
{
    class Context { }
    class BookingDirector { }

    class ActionMenu : IActionMenu
    {
        private Context context;
        public ActionMenu(Context context)
        {
            this.context = context;
        }

        public IBooking AddBooking(ECity city, EHotelType hotelType, int numberOfBookings)
        {
            Console.WriteLine("AddBooking");
            return new IBooking();
        }

        public void AddBookingMenu()
        {
            Console.WriteLine("AddBookingMenu");
        }

        public void ManageRequests(Customer customer)
        {
            Console.WriteLine("ManageRequests");
        }

        public void RequestExistingBooking(Customer customer)
        {
            Console.WriteLine("RequestExistingBooking");
        }

        public void RequestNewBooking(Customer customer)
        {
            Console.WriteLine("RequestNewBooking");
        }

        public void ShowFullReport()
        {
            Console.WriteLine("ShowFullReport");
        }

        public void ShowOffers()
        {
            Console.WriteLine("ShowFullReport");
        }
    }
}
