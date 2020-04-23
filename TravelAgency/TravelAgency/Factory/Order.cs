using System;
using TravelAgency.Decorator;

namespace TravelAgency.Factory
{
    class Order
    {
        private IBooking _booking;
        public Guid Id { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
        }

        public void Buy(IBooking booking)
        {
            _booking = booking;
        }
    }
}
