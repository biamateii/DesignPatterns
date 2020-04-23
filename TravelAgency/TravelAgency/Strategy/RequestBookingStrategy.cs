using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Repository;

namespace TravelAgency.Strategy
{
    public abstract class RequestBookingStrategy
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
                .Where(building => building.HotelType == request.HotelType
                                   && building.City == request.CityType)
                .Any();
        }

        public abstract void BuyingRequest(Request request);
    }
}
