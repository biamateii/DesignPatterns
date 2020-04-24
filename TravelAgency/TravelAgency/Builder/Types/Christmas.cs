using TravelAgency.Builder.Enums;
using TravelAgency.Decorator;

namespace TravelAgency.Builder.Types
{
    class Christmas: BookingBuilder
    {
       
        public Christmas(BasicBooking booking) : base(booking)
        {
            //Empty constructor
        }

        public override void SetCity()
        {
            this.Booking.City = ECity.EBerlin;
        }

        public override void SetNumberOfDays()
        {
            this.Booking.NumberOfDays = 7;
        }

        public override void SetNumberOfPersons()
        {
            this.Booking.NumberOfPersons = 5;
        }

        public override void SetCategory()
        {
            this.Booking.Category = ECategoryType.ECityBreak;
        }

        public override void SetPrice()
        {
            this.Booking.Price = 9000;
        }
    }
}
