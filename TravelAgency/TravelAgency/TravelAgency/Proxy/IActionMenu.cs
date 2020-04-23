using System;
using TravelAgency.Factory.Types;

namespace TravelAgency.Proxy
{
    class IBooking { }
    enum ECity { }
    enum EHotelType { }

    interface IActionMenu
    {
        IBooking AddBooking(ECity city, EHotelType hotelType, int numberOfBookings);

        void RequestExistingBooking(Customer customer);

        void RequestNewBooking(Customer customer);

        void ManageRequests(Customer customer);

        void ShowOffers();

        void ShowFullReport();

        void AddBookingMenu();
    }
}
