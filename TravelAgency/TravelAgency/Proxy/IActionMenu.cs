﻿using TravelAgency.Builder.Enums;
using TravelAgency.Decorator;
using TravelAgency.Decorator.enums;
using TravelAgency.Factory.Types;
using TravelAgency.Visitor;

namespace TravelAgency.Proxy
{
    interface IActionMenu
    {
        IBooking AddBooking(ECategoryType categoryType, EHotelType hotelType, int numberOfBookings);

        void RequestExistingBooking(Customer customer);

        void RequestNewBooking(Customer customer);

        void ManageRequests(Customer customer);

        void ShowOffers();

        void ShowOrders(Report report);

        void AddBookingMenu();
    }
}
