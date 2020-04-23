using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator.enums;
using TravelAgency.Factory.Types;

namespace TravelAgency.Strategy
{
    public class Request
    {
        public Customer Customer { get; set; }

        public EHotelType HotelType { get; set; }

        public ECityType CityType { get; set; }

        public ERequestType RequestType { get; set; }

        public override string ToString()
        {
            return $"REQUEST=> Request Type: {this.RequestType} Building type: {this.CityType}   Decor type: {this.HotelType} ";
        }
    }
}
