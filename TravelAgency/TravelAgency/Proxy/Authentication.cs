using System;
using System.Linq;
using TravelAgency.Factory;
using TravelAgency.Repository;

namespace TravelAgency.Proxy
{
    class Authentication : IAuthentication
    {
        private UsersRepository _users;

        public Authentication()
        {
            _users = new UsersRepository();
            _users.Seed();
        }

        public User Login(string username, string password)
        {
            var user = _users.Query
                .Where(u => u.Username == username
                    && u.Password == password)
                .FirstOrDefault();
            if (user == null)
            {
                Console.WriteLine("Ups.. Invalid credentials.");
                return null;
            }
            Console.WriteLine("Hi " + user.Username + " ! ಠᴗಠ");
            return user;
        }

        public void LogOut()
        {
            Console.WriteLine("Bye Bye ! ಠ_ಠ");
        }
    }
}
