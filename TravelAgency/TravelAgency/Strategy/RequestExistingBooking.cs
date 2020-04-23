using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Repository;

namespace TravelAgency.Strategy
{
    public class RequestExistingBooking : RequestBookingStrategy
    {
        public RequestExistingBuilding(RequestRepository requestRepository, BookingRepository bookingRepository) : base(requestRepository, bookingRepository)
        {
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
