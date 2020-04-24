using System;
using System.Collections.Generic;
using TravelAgency.Proxy;
using TravelAgency.Repository;

namespace TravelAgency.Strategy
{
    class RequestExistingBooking : RequestBookingStrategy
    {
        public RequestExistingBooking(RequestRepository requestRepository, BookingRepository bookingRepository) : base(requestRepository, bookingRepository)
        {
            //Empty constructor
        }

        public override void BuyingRequest(Request request)
        {
            if (!BookingExisting(request))
            {
                Console.WriteLine("Booking with the specificated properties doesn't exist. Create a new one as you prefer. \n");
                return;
            }


            _requestRepository.Add(request);
            Console.WriteLine("The request was succesfully submitted for an existing booking.");
        }
    }
}
