using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator.enums;

namespace TravelAgency.Decorator
{
    public interface IBooking : IVisitable
    {
        ECity City { get; set; }

        int NumberOfDays { get; set; }

        int NumberOfPersons { get; set; }

        ECategoryType Category { get; set; }

        double Price { get; set; }

        EHotelType HotelType { get; set; }

        List<EFacilityType> Facilities { get; set; }

        List<EAmenityType> Amenitites { get; set; }

        EBasisType BasisType { get; set; }


      
        void SetFacilities();

        void SetAmenities();

        void SetBasisType();

        void SetPrice();

        string ToString();

        IBooking Clone();

    }
}
