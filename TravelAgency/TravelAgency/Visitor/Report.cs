using System;
using System.Text;
using TravelAgency.Factory;

namespace TravelAgency.Visitor
{
    class Report : IVisitor
    {
        private int _noOrders;
        private StringBuilder _orders;

        public Report()
        {
            _noOrders = 0;
            _orders = new StringBuilder();
        }

        public void PrintReport()
        {
            Console.WriteLine("Your accepted bookings:");
            Console.WriteLine(_orders);
        }

        public void Visit(Order order)
        {
            _noOrders++;
            _orders.Append($"{_noOrders}. Order purchased: {order.ToString()}");
        }
    }
}
