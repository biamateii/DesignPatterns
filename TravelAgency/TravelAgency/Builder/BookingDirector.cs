using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Builder.Enums;
using TravelAgency.Builder.Types;

namespace TravelAgency.Builder
{
    class BookingDirector
    {
        IBookingBuilder bookingBuilder;

        public BookingDirector(ECategoryType CategoryType)
        {
            switch (CategoryType)
            {
                case ECategoryType.EChristmas:
                    this.bookingBuilder = new Christmas(new BasicBooking());
                    break;
                case ECategoryType.ECityBreak:
                    this.bookingBuilder = new CityBreak(new BasicBooking());
                    break;
                case ECategoryType.EEaster:
                    this.bookingBuilder = new Easter(new BasicBooking());
                    break;
                case ECategoryType.ENewYear:
                    this.bookingBuilder = new NewYear(new BasicBooking());
                    break;
                default: break;
            }

        }

        public void Construct()
        {
            bookingBuilder.SetCategory();
            bookingBuilder.SetCity();
            bookingBuilder.SetNumberOfDays();
            bookingBuilder.SetNumberOfPersons();
            bookingBuilder.SetPrice();
        }

        public BasicBooking GetBooking()
        {
            return bookingBuilder.GetBooking();
        }
    }
}
