using TravelAgency.Decorator;

namespace TravelAgency.Builder
{
    interface IBookingBuilder
    {
        void SetCity();

        void SetNumberOfDays();

        void SetNumberOfPersons();

        void SetCategory();

        void SetPrice();

        BasicBooking GetBooking();
    }
}
