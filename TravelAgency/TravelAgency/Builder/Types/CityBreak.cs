using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator;

namespace TravelAgency.Builder.Types
{
    class CityBreak: BookingBuilder
    {

        public CityBreak(BasicBooking booking):base(booking)
        {
            //Empty constructor
        }

        public override void SetCity()
        {
            this.Booking.City = ECity.EBerlin;
        }

        public override void SetNumberOfDays()
        {
            this.Booking.NumberOfDays = 4;
        }

        public override void SetNumberOfPersons()
        {
            this.Booking.NumberOfPersons = 2;
        }

        public override void SetCategory()
        {
            this.Booking.Category = ECategoryType.ECityBreak;
        }

        public override void SetPrice()
        {
            this.Booking.Price = 3000;
        }


    }
}
