using System;
using TravelAgency.Factory.Enums;

namespace TravelAgency.Factory.Types
{
    class Seller : User
    {
        public Seller(string username, string password) :
            base(username, password)
        {
            // Empty constructor
        }

        public override ERoleType RoleType()
        {
            return ERoleType.ESeller;
        }
    }
}