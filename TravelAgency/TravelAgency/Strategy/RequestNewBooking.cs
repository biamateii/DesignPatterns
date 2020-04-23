using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Repository;

namespace TravelAgency.Strategy
{
    public class RequestNewBooking : RequestBookingStrategy
    {
        public RequestNewBuilding(RequestRepository requestRepository, BookingRepository bookingRepository) : base(requestRepository, bookingRepository)
        {
        }

        public override void BuyingRequest(Request request)
        {
            if (BookingExisting(request))
            {
                Console.WriteLine("The building you want to buy is already existing in our catalogue. \n");

                return;
            }
            _requestRepository.Add(request);
            Console.WriteLine("The request was succesfully submitted for a new building;");
        }
    }
}
