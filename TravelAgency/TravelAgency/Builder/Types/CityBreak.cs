using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Builder.Enums;

namespace TravelAgency.Builder.Types
{
    class CityBreak : BookingBuilder
    {

        public CityBreak(BasicBooking booking):base(booking)
        {

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
            this.Booking.NumberOfPersons = 10;
        }

        public override void SetCategory()
        {
            this.Booking.Category = ECategoryType.ECityBreak;
        }

        public override void SetPrice()
        {
            this.Booking.Price = 5000;
        }


    }
}
