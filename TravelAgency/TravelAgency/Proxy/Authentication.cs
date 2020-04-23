﻿using System;
using TravelAgency.Factory;
using TravelAgency.Factory.FactoryTypes;
using TravelAgency.Factory.Types;
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
            Console.WriteLine("Login");
            User user;
            if(username.Equals("1"))
                user = new SellerFactory().GetUser(username, password);
            else
                user = new CustomerFactory().GetUser(username, password);

            return user;
        }

        public void LogOut()
        {
            Console.WriteLine("LogOut");
        }
    }
}