using System;
using TravelAgency.Factory.Enums;
using TravelAgency.Factory.Types;

namespace TravelAgency.Factory.FactoryTypes
{
    class CustomerFactory : UserFactory
    {

        public override User GetUser(string username, string password)
        {
            return new Customer(username, password);
        }
    }
}
