﻿namespace TravelAgency.Repository
{
    class Context
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
