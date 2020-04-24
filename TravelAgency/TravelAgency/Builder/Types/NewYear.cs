using TravelAgency.Builder.Enums;
using TravelAgency.Decorator;

namespace TravelAgency.Builder.Types
{
    class NewYear: BookingBuilder
    {
        public NewYear(BasicBooking booking) : base(booking)
        {
            //Empty constructor
        }

        public override void SetCity()
        {
            this.Booking.City = ECity.EDenver;
        }

        public override void SetNumberOfDays()
        {
            this.Booking.NumberOfDays = 3;
        }

        public override void SetNumberOfPersons()
        {
            this.Booking.NumberOfPersons = 6;
        }

        public override void SetCategory()
        {
            this.Booking.Category = ECategoryType.ENewYear;
        }

        public override void SetPrice()
        {
            this.Booking.Price = 12000;
        }



    }
}
