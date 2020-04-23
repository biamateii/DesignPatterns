using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgency.Utils
{
    public static class Menu
    {
        public static readonly string MenuActions = @"Please select one of the following actions:
                1. Login
                2. Logout
                3. Add Building
                4. Manage requests
                5. See offers
                6. Buy existing
                7. Buy new
                8. Show full report
                9. Show statistics";

        public static readonly string ManageRequests = @"Please select one of the following actions:
                1. Aprove request
                2. Decline request
                3. Continue
                4. Go back";

        public static readonly string ShowOffers = @"Please select one of the following actions:
                1. Show All
                2. Order By Types
                3. Filter By Price - Grater than
                4. Filter By Price - Lower than
                5. Go back";
        public static readonly string BuildingType = @"Please select which Type of Building you would like to buy:
                1. Cottage
                2. Detached House
                3. Villa
                4. Go back";
        public static readonly string DecorationType = @"Please select which Type of Decoration you would like to buy:
                1. Basic
                2. Silver
                3. Gold
                4. Platinum
                5. Go back";

        public static readonly string AddBuildingType = @"Please select one of the following types of buildings:
                1. Cottage
                2. DetachedHouse
                3. Villa";

        public static readonly string AddBuildingDecorType = @"Please select one of the following types of building package:
                1. Basic
                2. Silver
                3. Gold
                4. Platinum";
    }
}
