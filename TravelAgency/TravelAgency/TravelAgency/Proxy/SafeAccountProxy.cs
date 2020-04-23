using System;
using TravelAgency.Factory;
using TravelAgency.Factory.Types;

namespace TravelAgency.Proxy
{
    class SafeAccountProxy: IActionMenu, IAuthentication
    {
        private User _user;
        private IActionMenu _actionMenu;
        private IAuthentication _authentication;

        public SafeAccountProxy(IActionMenu actionMenu, IAuthentication authentication)
        {
            _authentication = authentication;
            _actionMenu = actionMenu;
        }

        public IBooking AddBooking(ECity city, EHotelType hotelType, int numberOfBookings)
        {
            return _actionMenu.AddBooking(city, hotelType, numberOfBookings);
        }

        public void AddBookingMenu()
        {
            _actionMenu.AddBookingMenu();
        }

        public User Login(string username, string password)
        {
            _user = _authentication.Login(username, password);
            return _user;
        }

        public void LogOut()
        {
            _authentication.LogOut();
        }

        public void ManageRequests(Customer customer)
        {
            _actionMenu.ManageRequests(customer);
        }

        public void RequestExistingBooking(Customer customer)
        {
            _actionMenu.RequestExistingBooking(customer);
        }

        public void RequestNewBooking(Customer customer)
        {
            _actionMenu.RequestNewBooking(customer);
        }

        public void ShowFullReport()
        {
            _actionMenu.ShowFullReport();
        }

        public void ShowOffers()
        {
            _actionMenu.ShowOffers();
        }

        public void showOptions()
        {

        }

        private void HandleDefaultView()
        {

        }

        private void HandleCustomerView()
        {

        }

        private void HandleSellerView()
        {

        }
    }
}
