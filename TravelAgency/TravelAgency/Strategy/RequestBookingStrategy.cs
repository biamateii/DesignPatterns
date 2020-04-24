using System.Linq;
using TravelAgency.Proxy;
using TravelAgency.Repository;

namespace TravelAgency.Strategy
{
    abstract class RequestBookingStrategy
    {
        protected RequestRepository _requestRepository;
        protected BookingRepository _bookingRepository;

        public RequestBookingStrategy(RequestRepository requestRepository, BookingRepository bookingRepository)
        {
            this._requestRepository = requestRepository;
            this._bookingRepository = bookingRepository;
        }

        protected bool BookingExisting(Request request)
        {
            return _bookingRepository.Query
                .Where(booking => booking.HotelType == request.HotelType
                                   && booking.Category == request.CategoryType)
                .Any();
        }

        public abstract void BuyingRequest(Request request);
    }
}
