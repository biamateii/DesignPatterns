using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Repository
{
    public class Context
    {
        public BookingRepository BookingRepository { get; set; }

        public RequestRepository RequestRepository { get; set; }

        public UsersRepository UsersRepository { get; set; }

        public Context()
        {
            this.BookingRepository = new BookingRepository();
            this.UsersRepository = new UsersRepository();
            this.RequestRepository = new RequestRepository();
            BookingRepository.Seed();
            UsersRepository.Seed();
        }
    }
}
