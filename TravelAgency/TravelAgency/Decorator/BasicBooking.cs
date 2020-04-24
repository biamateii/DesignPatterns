using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator.enums;
using TravelAgency.Utils;

namespace TravelAgency.Decorator
{
    [Serializable]
    class BasicBooking : IBooking
    {
        public BasicBooking()
        {
            HotelType = EHotelType.Basic;
            SetAmenities();
            SetBasisType();
            SetFacilities();
            SetPrice();
        }

        public ECity City { get; set; }
        public int NumberOfDays { get; set; }
        public int NumberOfPersons { get; set; }
        public ECategoryType Category { get; set; }
        public double Price { get; set; }
        public EHotelType HotelType { get; set; }
        public List<EFacilityType> Facilities { get; set; }
        public List<EAmenityType> Amenitites { get; set; }
        public EBasisType BasisType { get; set; }

        public void SetFacilities()
        {
            Facilities = new List<EFacilityType>();
        }

        public void SetAmenities()
        {
            Amenitites = new List<EAmenityType>();
        }

        public void SetBasisType()
        {
            BasisType = EBasisType.ERoomOnly;
        }

        public void SetPrice()
        {
            Price = 0;
        }

        public override string ToString()
        {
            return DataFormatting.WriteToConsole(this);
        }

        public IBooking Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;
                    var clone = (BasicBooking)formatter.Deserialize(stream);
                    return clone;
                }
                return null;

            }
        }
    }
}

        
    
