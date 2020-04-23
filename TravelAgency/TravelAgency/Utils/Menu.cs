using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgency.Utils
{
    static class Menu
    {
        public static readonly string MenuActions = @"Please select one of the following actions:
                1. Login  ಠᴗಠ
                2. Logout ಠ_ಠ
                3. Let's add some bookings!
                4. Check for requests!
                5. Take a look at our offers!
                6. I want a booking!
                7. Request for your own booking!
                8. Show full report
                9. Show statistics";

        public static readonly string ManageRequests = @"Please select one of the following actions:
                1. Aprove this request  ✔
                2. Decline this request ✘
                3. Continue
                4. Go back";

        public static readonly string ShowOffers = @"Please select one of the following actions:
                1. Let's see ALL the offers!
                2. Order the offers by the TYPE of booking
                3. Filter by PRICE ~ Grater than ~ 
                4. Filter by PRICE ~ Lower than ~
                5. Go back";

        public static readonly string BookingType = @"Please select which Type of Booking you would like to buy:
                1. Christmas
                2. CityBreak
                3. Easter
                4. NewYear
                4. Go back";

        public static readonly string HotelType = @"Please select which Type of Hotel you would like to buy:
                1. Standard Hotel    ✌
                2. Three Stars Hotel ★★★
                3. Four Stars Hotel  ★★★★
                4. Five Stars Hotel  ★★★★★
                5. Go back";

        public static readonly string AddBookingType = @"Please select one of the following types of booking:
                1. Christmas
                2. CityBreak
                3. Easter
                4. NewYear";

        public static readonly string AddHotelType = @"Please select one of the following types of booking package:
                1. Standard Hotel    ✌
                2. Three Stars Hotel ★★★
                3. Four Stars Hotel  ★★★★
                4. Five Stars Hotel  ★★★★★";
    }
}
