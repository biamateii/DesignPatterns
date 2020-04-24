
using TravelAgency.Factory.Types;

namespace TravelAgency.Factory.FactoryTypes
{
    class SellerFactory : UserFactory
    {

        public override User GetUser(string username, string password)
        {
            return new Seller(username, password);

        }
    }
}
