using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Decorator.enums;

namespace TravelAgency.Decorator.DecoraorTypes
{
    class HotelFourStarsDecorator:BookingDecorator
    {

        public HotelFourStarsDecorator(IBooking DecoratedBooking) : base(DecoratedBooking)
        {
            this.DecoratedBooking.HotelType = enums.EHotelType.EFourStars;
            SetPrice();
            SetFacilities();
            SetBasisType();
            SetAmenities();
        }

        public override void SetPrice()
        {
            this.DecoratedBooking.Price = 3500;
        }

        public override void SetFacilities()
        {
            this.DecoratedBooking.Facilities.AddRange(new List<EFacilityType>()
            {
                EFacilityType.EFreeParking,
                EFacilityType.EPool
            });
        }

        public override void SetBasisType()
        {
            this.DecoratedBooking.BasisType = EBasisType.EBadAndBreakfast;
        }

        public override void SetAmenities()
        {
            this.DecoratedBooking.Amenitites.AddRange(new List<EAmenityType>()
            {
               EAmenityType.EAirConditioning,
               EAmenityType.EShampoo,
               EAmenityType.ETV,
               EAmenityType.EWifi,
               EAmenityType.EKitchen
            });
        }
    }
}
