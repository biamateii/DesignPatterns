using System;
using TravelAgency.Proxy;
using TravelAgency.Utils;

namespace TravelAgency
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var context = new Context();
            var accountService = new SafeAccountProxy(new ActionMenu(context), new Authentication());

            while (true)
            {
                int action;
                Console.WriteLine(Menu.MenuActions);


                if (!int.TryParse(Console.ReadLine(), out action))
                {
                    Console.WriteLine("Invalid request. Please select one of existing actions.");
                    continue;
                }

                switch (action)
                {
                    case 1:
                        Console.WriteLine("Account:");
                        string accountName = Console.ReadLine();
                        Console.WriteLine("Password:");
                        string accountPass = Console.ReadLine();
                        accountService.Login(accountName, accountPass);
                        break;
                    case 2:
                        accountService.LogOut();
                        break;
                    case 3:
                        accountService.AddBookingMenu();
                        break;
                    case 4:
                        accountService.ManageRequests(null);
                        break;
                    case 5:
                        accountService.ShowOffers();
                        break;
                    case 6:
                        accountService.RequestExistingBooking(null);
                        break;
                    case 7:
                        accountService.RequestNewBooking(null);
                        break;
                    case 8:
                        accountService.ShowFullReport();
                        break;
                    default:
                        Console.WriteLine("Invalid request. Please select one of existing actions.");
                        continue;

                }
            }
        }
    }
}
