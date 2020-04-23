using System;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator.enums;
using TravelAgency.Factory.Types;
using TravelAgency.Proxy.Types;

namespace TravelAgency.Proxy
{
    class Request
    {
        public Customer Customer { get; set; }
        public EHotelType HotelType { get; set; }
        public ECategoryType CategoryType { get; set; }
        public ERequestType RequestType { get; set; }

    }
}
