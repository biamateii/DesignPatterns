using TravelAgency.Factory;

namespace TravelAgency.Proxy
{
    interface IAuthentication
    {
        User Login(string username, string password);

        void LogOut();
    }
}
