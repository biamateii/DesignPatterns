using System;
using TravelAgency.Factory.Enums;

namespace TravelAgency.Factory
{
    abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        abstract public ERoleType RoleType();
    }
}
