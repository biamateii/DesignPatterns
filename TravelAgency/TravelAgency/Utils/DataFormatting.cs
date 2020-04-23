using System;
using System.Text;
using TravelAgency.Decorator;

namespace TravelAgency.Utils
{
    class DataFormatting
    {
        public static string WriteToConsole(IBooking booking)
        {
            var facilities = new StringBuilder();
            booking.Facilities.ForEach(facility => facilities.Append($"{facility.ToString().Substring(1)}, "));
            var amenities = new StringBuilder();
            booking.Amenitites.ForEach(amenity => amenities.Append($"{amenity.ToString().Substring(1)}, "));

            return $@" Don't miss our offer!
==========================================================
What type of booking?   {booking.Category.ToString().Substring(1)}
Where to go?            {booking.City.ToString().Substring(1)}
How long?               {booking.NumberOfDays} days
How many persons?       {booking.NumberOfPersons} 
Where to stay?          Hotel {booking.HotelType.ToString().Substring(1)}
What kind of package?   {booking.BasisType.ToString().Substring(1)}
Your facilities:        {facilities.ToString().Remove(facilities.Length - 2)}
Your amenities:         {amenities.ToString().Remove(amenities.Length - 2)}

Total price:            ${booking.Price} 
=========================================================={Environment.NewLine}";
        }
    }
}
