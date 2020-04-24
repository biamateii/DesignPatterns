using System.Collections.Generic;
using TravelAgency.Factory.Enums;
using TravelAgency.Visitor;

namespace TravelAgency.Factory.Types
{
    class Customer : User, IVisitable
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

        public void Accept(IVisitor visitor)
        {
            foreach (var order in Orders)
            {
                if (order.IsVisited == false)
                {
                    order.Accept(visitor);
                }
            }
        }
    }
}
