using System;
using TravelAgency.Factory.Enums;

namespace TravelAgency.Factory.FactoryTypes
{
    class SellerFactory : UserFactory
    {

        public override User GetUser(string username, string password, ERoleType roleType)
        {
            throw new NotImplementedException();
        }
    }
}
