﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Builder
{
    class BookingBuilder : IBookingBuilder
    {
        
        public BasicBooking Booking { get; set; }

        public BookingBuilder(BasicBooking booking)
        {
            Booking = booking;
        }

        public abstract void SetCategory();


        public abstract void SetCity();


        public abstract void SetNumberOfDays();


        public abstract void SetNumberOfPersons();

        public abstract void SetPrice();
        

        public BasicBooking GetBooking()
        {
            return this.Booking;
        }
    }
}
