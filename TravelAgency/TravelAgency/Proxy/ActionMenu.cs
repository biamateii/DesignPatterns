using System;
using TravelAgency.Builder;
using TravelAgency.Builder.Enums;
using TravelAgency.Decorator;
using TravelAgency.Decorator.enums;
using TravelAgency.Decorator.DecoraorTypes;
using TravelAgency.Factory.Types;
using TravelAgency.Repository;
using TravelAgency.Utils;
using TravelAgency.Factory;
using TravelAgency.Proxy.Types;
using System.Linq;

namespace TravelAgency.Proxy
{
    class ActionMenu : IActionMenu
    {
        private Context context;
        public ActionMenu(Context context)
        {
            this.context = context;
        }

        public IBooking AddBooking(ECategoryType categoryType, EHotelType hotelType, int numberOfBookings)
        {
            Console.WriteLine("AddBooking");
            var bookingDirector = new BookingDirector(categoryType);
            bookingDirector.Construct();
            var basicBooking = bookingDirector.GetBooking();
            IBooking createdBooking = new BasicBooking();
            switch (hotelType)
            {
                case EHotelType.Basic:
                    createdBooking = basicBooking;
                    context.BookingRepository.Add(basicBooking);
                    break;
                case EHotelType.EThreeStars:
                    var threeStarsHotel = new HotelThreeStarsDecorator(basicBooking);
                    createdBooking = threeStarsHotel;
                    context.BookingRepository.Add(threeStarsHotel);
                    break;
                case EHotelType.EFourStars:
                    var fourStarsHotel = new HotelThreeStarsDecorator(basicBooking);
                    createdBooking = fourStarsHotel;
                    context.BookingRepository.Add(fourStarsHotel);
                    break;
                case EHotelType.EFiveStars:
                    var fiveStarsHotel = new HotelThreeStarsDecorator(basicBooking);
                    createdBooking = fiveStarsHotel;
                    context.BookingRepository.Add(fiveStarsHotel);
                    break;
            }
            for (int i = 0; i < numberOfBookings - 1; i++)
            {
                var clonedBooking = createdBooking.Clone();
                context.BookingRepository.Add(clonedBooking);
            }
            return createdBooking;
        }

        public void AddBookingMenu()
        {
            Console.WriteLine("AddBookingMenu");
            int selectCategoryType;
            int selectHotelType;
            ECategoryType categoryType = 0;
            EHotelType hotelType = 0;
            while (true)
            {
                Console.WriteLine(Menu.AddBookingType);
                if (!int.TryParse(Console.ReadLine(), out selectCategoryType))
                {
                    Console.WriteLine("Invalid request. Please select one of existing booking type.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            switch (selectCategoryType)
            {
                case 1:
                    categoryType = ECategoryType.EChristmas;
                    break;
                case 2:
                    categoryType = ECategoryType.ECityBreak;
                    break;
                case 3:
                    categoryType = ECategoryType.EEaster;
                    break;
                case 4:
                    categoryType = ECategoryType.ENewYear;
                    break;
            }
            while (true)
            {
                Console.WriteLine(Menu.AddHotelType);
                if (!int.TryParse(Console.ReadLine(), out selectHotelType))
                {
                    Console.WriteLine("Invalid request. Please select one of existing packages.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            switch (selectHotelType)
            {
                case 1:
                    hotelType = EHotelType.Basic;
                    break;
                case 2:
                    hotelType = EHotelType.EThreeStars;
                    break;
                case 3:
                    hotelType = EHotelType.EFourStars;
                    break;
                case 4:
                    hotelType = EHotelType.EFiveStars;
                    break;
            }

            Console.WriteLine("Number of houses:");
            int numberOfHouses = Convert.ToInt32(Console.ReadLine());
            AddBooking(categoryType, hotelType, numberOfHouses);
        }

        public void ManageRequests(Customer customer)
        {
            Console.WriteLine("ManageRequests");
            Console.WriteLine($"Numbers of requests: {context.RequestRepository.Query.Count()}");
            foreach (Request request in this.context.RequestRepository)
            {
                int action;
                while (true)
                {
                    Console.WriteLine(request.ToString());
                    Console.WriteLine(Menu.ManageRequests);

                    if (!int.TryParse(Console.ReadLine(), out action))
                    {
                        Console.WriteLine("Invalid request. Please select one of existing actions.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                IBooking booking = null;
                var order = new Order();

                switch (request.RequestType)
                {
                    case ERequestType.New:
                        booking = this.AddBooking(request.CategoryType, request.HotelType, 1);
                        break;
                    case ERequestType.Existing:
                        booking = context.BookingRepository.Query.Where(b => b.HotelType == request.HotelType &&
                        b.Category == request.CategoryType).FirstOrDefault();
                        break;
                }

                if (booking == null)
                {
                    Console.WriteLine("This request will be removed because we already sold this booking");
                    continue;
                }

                switch (action)
                {
                    case 1:
                        order.Buy(booking);
                        request.Customer.Add(order);
                        this.context.BookingRepository.Remove(booking);
                        this.context.RequestRepository.Remove(request);
                        break;
                    case 2:
                        this.context.RequestRepository.Remove(request);
                        break;
                    case 3:
                        break;
                    case 4:
                        return;
                }

                if (context.RequestRepository.Query.Count() <= 0)
                {
                    Console.WriteLine("There are no more requests");
                    return;
                }
            }
        }

        public void RequestExistingBooking(Customer customer)
        {
            Console.WriteLine("RequestExistingBooking");
            ShowOffers();
            var request = new Request();
            int action;
            while (true)
            {
                Console.WriteLine(Menu.BookingType);

                if (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.WriteLine("Invalid request. Please select one of existing actions.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            switch (action)
            {
                case 1:
                    request.CategoryType = ECategoryType.EChristmas;
                    break;
                case 2:
                    request.CategoryType = ECategoryType.ECityBreak;
                    break;
                case 3:
                    request.CategoryType = ECategoryType.EEaster;
                    break;
                case 4:
                    request.CategoryType = ECategoryType.ENewYear;
                    break;
                case 5:
                    return;
            }

            while (true)
            {
                Console.WriteLine(Menu.HotelType);

                if (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.WriteLine("Invalid request. Please select one of existing actions.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            switch (action)
            {
                case 1:
                    request.HotelType = EHotelType.Basic;
                    break;
                case 2:
                    request.HotelType = EHotelType.EThreeStars;
                    break;
                case 3:
                    request.HotelType = EHotelType.EFourStars;
                    break;
                case 4:
                    request.HotelType = EHotelType.EFiveStars;
                    break;
                case 5:
                    return;
            }
            request.RequestType = ERequestType.Existing;
            request.Customer = customer;

            //var requestingService = new RequestExistingBooking(context.RequestRepository, context.BookingRepository);
            //requestingService.BuyingRequest(request);
        }

        public void RequestNewBooking(Customer customer)
        {
            var request = new Request();
            int action;
            while (true)
            {
                Console.WriteLine(Menu.BookingType);

                if (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.WriteLine("Invalid request. Please select one of existing actions.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            switch (action)
            {
                case 1:
                    request.CategoryType = ECategoryType.EChristmas;
                    break;
                case 2:
                    request.CategoryType = ECategoryType.ECityBreak;
                    break;
                case 3:
                    request.CategoryType = ECategoryType.EEaster;
                    break;
                case 4:
                    request.CategoryType = ECategoryType.ENewYear;
                    break;
                case 5:
                    return;
            }

            while (true)
            {
                Console.WriteLine(Menu.HotelType);

                if (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.WriteLine("Invalid request. Please select one of existing actions.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            switch (action)
            {
                case 1:
                    request.HotelType = EHotelType.Basic;
                    break;
                case 2:
                    request.HotelType = EHotelType.EThreeStars;
                    break;
                case 3:
                    request.HotelType = EHotelType.EFourStars;
                    break;
                case 4:
                    request.HotelType = EHotelType.EFiveStars;
                    break;
                case 5:
                    return;
            }
            request.RequestType = ERequestType.New;
            request.Customer = customer;

            //var requestingService = new RequestNewBooking(context.RequestRepository, context.BookingingsRepository);
            //requestingService.BuyingRequest(request);
        }

        public void ShowFullReport()
        {
            Console.WriteLine("ShowFullReport");
        }

        public void ShowOffers()
        {
            Console.WriteLine("ShowOffers");
            int action;
            while (true)
            {
                Console.WriteLine(Menu.ShowOffers);

                if (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.WriteLine("Invalid request. Please select one of existing actions.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            switch (action)
            {
                case 1:
                    foreach (var booking in this.context.BookingRepository)
                    {
                        Console.WriteLine(booking.ToString());
                    }
                    break;
                case 2:
                    var orderedBookings = this.context.BookingRepository.Query.OrderBy(b => b.Category).ThenBy(b => b.HotelType).ToList();
                    foreach (var booking in orderedBookings)
                    {
                        Console.WriteLine(booking.ToString());
                    }
                    return;
                case 3:
                    double price;
                    while (true)
                    {
                        Console.WriteLine("Price :");

                        if (!double.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("Invalid request. Please select one of existing actions.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    var priceGT = this.context.BookingRepository.Query.Where(booking => booking.Price > price).ToList();
                    foreach (var booking in priceGT)
                    {
                        Console.WriteLine(booking.ToString());
                    }
                    return;
                case 4:
                    double price2;
                    while (true)
                    {
                        Console.WriteLine("Price :");

                        if (!double.TryParse(Console.ReadLine(), out price2))
                        {
                            Console.WriteLine("Invalid request. Please select one of existing actions.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    var priceLD = this.context.BookingRepository.Query.Where(booking => booking.Price < price2).ToList();
                    foreach (var booking in priceLD)
                    {
                        Console.WriteLine(booking.ToString());
                    }
                    return;
                case 5:

                    return;
            }

        }
    }
}
