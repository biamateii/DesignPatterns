using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Decorator.enums;

namespace TravelAgency.Decorator.DecoraorTypes
{
    class HotelFiveStarsDecorator:BookingDecorator
    {

        public HotelFiveStarsDecorator(IBooking DecoratedBooking) : base(DecoratedBooking)
        {
            this.DecoratedBooking.HotelType = enums.EHotelType.EFiveStars;
            SetPrice();
            SetFacilities();
            SetBasisType();
            SetAmenities();
        }

        public override void SetPrice()
        {
            this.DecoratedBooking.Price = 5000;
        }

        public override void SetFacilities()
        {
            this.DecoratedBooking.Facilities.AddRange(new List<EFacilityType>()
            {
                EFacilityType.EFreeParking,
                EFacilityType.EGym,
                EFacilityType.EHotTub,
                EFacilityType.EPool
            });
        }

        public override void SetBasisType()
        {
            this.DecoratedBooking.BasisType = EBasisType.EAllInclusive;
        }

        public override void SetAmenities()
        {
            this.DecoratedBooking.Amenitites.AddRange(new List<EAmenityType>()
            {
               EAmenityType.EAirConditioning,
               EAmenityType.EShampoo,
               EAmenityType.ETV,
               EAmenityType.EWifi,
               EAmenityType.EWashingMachine
            });
        }
    }
}
