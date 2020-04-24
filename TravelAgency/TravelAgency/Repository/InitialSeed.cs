using TravelAgency.Builder;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator.DecoraorTypes;
using TravelAgency.Factory.FactoryTypes;

namespace TravelAgency.Repository
{
    static class IntitialSeed
    {
        public static void Seed(this UsersRepository repository)
        {
            repository.Add(new SellerFactory().GetUser("Ioana", "pass"));
            repository.Add(new SellerFactory().GetUser("Maria", "pass"));
            repository.Add(new SellerFactory().GetUser("Sara", "pass"));
            repository.Add(new CustomerFactory().GetUser("user1", "pass"));
            repository.Add(new CustomerFactory().GetUser("user2", "pass"));
            repository.Add(new CustomerFactory().GetUser("user3", "pass"));
        }

        public static void Seed(this BookingRepository repository)
        {
            var christmasBookingDirector = new BookingDirector(ECategoryType.EChristmas);
            christmasBookingDirector.Construct();
            var christmasBooking = christmasBookingDirector.GetBooking();

            var newYearBookingDirector = new BookingDirector(ECategoryType.ENewYear);
            newYearBookingDirector.Construct();
            var newYearBooking = newYearBookingDirector.GetBooking();

            var cityBreakBookingDirector = new BookingDirector(ECategoryType.ECityBreak);
            cityBreakBookingDirector.Construct();
            var cityBreakBooking = cityBreakBookingDirector.GetBooking();

            var threeStarsHotelChr = new HotelThreeStarsDecorator(christmasBooking);
            var threeStarsHotelNewYear = new HotelThreeStarsDecorator(newYearBooking);

            var fiveStarsHotelCityBr = new HotelFiveStarsDecorator(cityBreakBooking);

            repository.Add(threeStarsHotelChr);
            repository.Add(threeStarsHotelNewYear);
            repository.Add(fiveStarsHotelCityBr);
        }
    }
}
