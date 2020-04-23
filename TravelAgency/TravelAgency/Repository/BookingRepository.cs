using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TravelAgency.Decorator;

namespace TravelAgency.Repository
{
    class BookingRepository : IEnumerable
    {
        private List<IBooking> _bookings;

        public IQueryable<IBooking> Query { get => _bookings.AsQueryable(); }

        public BookingRepository()
        {
            _bookings = new List<IBooking>();
        }

        public void AddRange(params IBooking[] bookings)
        {
            if (bookings == null)
            {
                return;
            }

            _bookings.AddRange(bookings);
        }

        public void Add(IBooking booking)
        {
            if (booking == null)
            {
                return;
            }

            _bookings.Add(booking);
        }

        public void Remove(IBooking booking)
        {
            _bookings.Remove(booking);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var booking in _bookings.ToList())
            {
                yield return booking;
            }
        }
    }
}
