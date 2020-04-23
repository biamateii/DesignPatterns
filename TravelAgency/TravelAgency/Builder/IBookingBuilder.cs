using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Decorator;

namespace TravelAgency.Builder
{
    interface IBookingBuilder
    {
        void SetCity();

        void SetNumberOfDays();

        void SetNumberOfPersons();

        void SetCategory();

        void SetPrice();

        BasicBooking GetBooking();
    }
}
