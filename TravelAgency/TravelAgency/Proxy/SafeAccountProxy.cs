using System;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator;
using TravelAgency.Decorator.enums;
using TravelAgency.Factory;
using TravelAgency.Factory.Enums;
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

        public IBooking AddBooking(ECategoryType categoryType, EHotelType hotelType, int numberOfBookings)
        {
            if (_user != null && _user.RoleType() == ERoleType.ESeller)
            {
                return _actionMenu.AddBooking(categoryType, hotelType, numberOfBookings);
            }
            else
            {
                Console.WriteLine("Access denied!");
                return null;
            }
        }

        public void AddBookingMenu()
        {
            if (_user != null && _user.RoleType() == ERoleType.ESeller)
            {
                _actionMenu.AddBookingMenu();
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        public User Login(string username, string password)
        {
            var authentificatedUser = _authentication.Login(username, password);
            if (authentificatedUser == null)
            {
                return null;
            }
            _user = authentificatedUser;
            return _user;
        }

        public void LogOut()
        {
            if (_user != null)
            {
                _authentication.LogOut();
                var user = _user as Customer;

                _user = null;
            }
        }

        public void ManageRequests(Customer customer)
        {
            if (_user != null && _user.RoleType() == ERoleType.ESeller)
            {
                _actionMenu.ManageRequests(_user as Customer);
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        public void RequestExistingBooking(Customer customer)
        {
            if (_user != null && _user.RoleType() == ERoleType.ECustomer)
            {
                _actionMenu.RequestExistingBooking(_user as Customer);
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        public void RequestNewBooking(Customer customer)
        {
            if (_user != null && _user.RoleType() == ERoleType.ECustomer)
            {
                _actionMenu.RequestNewBooking(_user as Customer);
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        public void ShowFullReport()
        {
            if (_user != null && _user.RoleType() == ERoleType.ESeller)
            {
                _actionMenu.ShowFullReport();
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        public void ShowOffers()
        {
            if (_user != null)
            {
                _actionMenu.ShowOffers();
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}
