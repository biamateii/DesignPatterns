using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator.enums;

namespace TravelAgency.Decorator
{
    [Serializable]
    class BasicBooking : IBooking
    {
        public BasicBooking()
        {
            this.HotelType = EHotelType.Basic;
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
        EHotelType IBooking.HotelType { get; set; }
        List<EFacilityType> IBooking.Facilities { get; set; }
        List<EAmenityType> IBooking.Amenitites { get; set; }
        EBasisType IBooking.BasisType { get; set; }

        IBooking Clone()
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

        public void SetFacilities()
        {
            throw new NotImplementedException();
        }

        public void SetAmenities()
        {
            throw new NotImplementedException();
        }

        public void SetBasisType()
        {
            throw new NotImplementedException();
        }

        public void SetPrice()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

        
    
