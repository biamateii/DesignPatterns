using System;
using TravelAgency.Decorator;
using TravelAgency.Visitor;

namespace TravelAgency.Factory
{
    class Order: IVisitable
    {
        private IBooking _booking;
        public bool IsVisited { get; set; }
        public Guid Id { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
            IsVisited = false;
        }

        public void Buy(IBooking booking)
        {
            _booking = booking;
        }

        public void Accept(IVisitor visitor)
        {
            IsVisited = true;
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return _booking.ToString();
        }
    }
}
