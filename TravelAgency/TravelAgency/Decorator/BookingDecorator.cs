using System.Collections.Generic;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator.enums;

namespace TravelAgency.Decorator
{
    abstract class BookingDecorator : IBooking
    {
        protected IBooking DecoratedBooking;

        public BookingDecorator(IBooking DecoratedBooking)
        {
            this.DecoratedBooking = DecoratedBooking;
        }

        public ECity City { get => this.DecoratedBooking.City; set => this.DecoratedBooking.City = value; }
        public int NumberOfDays { get => this.DecoratedBooking.NumberOfDays; set => this.DecoratedBooking.NumberOfDays = value; }
        public int NumberOfPersons { get => this.DecoratedBooking.NumberOfPersons; set => this.DecoratedBooking.NumberOfPersons = value; }
        public ECategoryType Category { get => this.DecoratedBooking.Category; set => this.DecoratedBooking.Category = value; }
        public double Price { get => this.DecoratedBooking.Price; set => this.DecoratedBooking.Price = value; }
        public EHotelType HotelType { get => this.DecoratedBooking.HotelType; set => this.DecoratedBooking.HotelType = value; }
        public List<EFacilityType> Facilities { get => this.DecoratedBooking.Facilities; set => this.DecoratedBooking.Facilities = value; }
        public List<EAmenityType> Amenitites { get => this.DecoratedBooking.Amenitites; set => this.DecoratedBooking.Amenitites = value; }
        public EBasisType BasisType { get => this.DecoratedBooking.BasisType; set => this.DecoratedBooking.BasisType = value; }

        public abstract void SetAmenities();


        public abstract void SetBasisType();


        public abstract void SetFacilities();


        public abstract void SetPrice();


        public IBooking Clone()
        {
            return this.DecoratedBooking.Clone();
        }

        public override string ToString()
        {
            return this.DecoratedBooking.ToString();
        }
    }
}
