using System;
using System.Collections.Generic;
using TravelAgency.Factory.Enums;

namespace TravelAgency.Factory.Types
{
    class Customer : User
    {
        public List<Order> Orders { get; set; }

        public Customer(string username, string password):
            base(username, password)
        {
            Orders = new List<Order>();
        }

        public override ERoleType RoleType()
        {
            return ERoleType.ECustomer;
        }

        public void Add(Order order)
        {
            Orders.Add(order);
        }
    }
}
