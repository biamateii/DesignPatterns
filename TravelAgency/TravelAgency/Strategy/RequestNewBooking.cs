using System;
using TravelAgency.Proxy;
using TravelAgency.Repository;

namespace TravelAgency.Strategy
{
    class RequestNewBooking : RequestBookingStrategy
    {
        public RequestNewBooking(RequestRepository requestRepository, BookingRepository bookingRepository) : base(requestRepository, bookingRepository)
        {
            //Empty constructor
        }

        public override void BuyingRequest(Request request)
        {
            if (BookingExisting(request))
            {
                Console.WriteLine("The booking you want to buy is already existing in our catalogue. \n");

                return;
            }
            _requestRepository.Add(request);
            Console.WriteLine("The request was succesfully submitted for a new booking;");
        }
    }
}
