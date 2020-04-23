using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Decorator.enums;

namespace TravelAgency.Decorator.DecoraorTypes
{
    class HotelThreeStarsDecorator:BookingDecorator
    {
        public HotelThreeStarsDecorator(IBooking DecoratedBooking) : base(DecoratedBooking)
        {
            this.DecoratedBooking.HotelType = enums.EHotelType.EThreeStars;
            SetPrice();
            SetFacilities();
            SetBasisType();
            SetAmenities();
        }

        public override void SetPrice()
        {
            this.DecoratedBooking.Price = 2000;
        }

        public override void SetFacilities()
        {
            this.DecoratedBooking.Facilities.AddRange(new List<EFacilityType>()
            {
                EFacilityType.EFreeParking,
            });
        }

        public override void SetBasisType()
        {
            this.DecoratedBooking.BasisType = EBasisType.ERoomOnly;
        }

        public override void SetAmenities()
        {
            this.DecoratedBooking.Amenitites.AddRange(new List<EAmenityType>()
            {
               EAmenityType.EAirConditioning,
               EAmenityType.EShampoo,
               EAmenityType.ETV,
               EAmenityType.EWifi
            });
        }


    }
}
