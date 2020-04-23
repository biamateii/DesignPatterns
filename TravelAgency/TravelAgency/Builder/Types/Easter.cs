using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator;

namespace TravelAgency.Builder.Types
{
    class Easter: BookingBuilder
    {
        public Easter(BasicBooking booking) : base(booking)
        {
            //Empty constructor
        }

        public override void SetCity()
        {
            this.Booking.City = ECity.ETokyo;
        }

        public override void SetNumberOfDays()
        {
            this.Booking.NumberOfDays = 6;
        }

        public override void SetNumberOfPersons()
        {
            this.Booking.NumberOfPersons = 8;
        }

        public override void SetCategory()
        {
            this.Booking.Category = ECategoryType.EEaster;
        }

        public override void SetPrice()
        {
            this.Booking.Price = 8500;
        }
    }
}
