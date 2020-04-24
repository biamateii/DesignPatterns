using TravelAgency.Decorator;
using TravelAgency.Factory;
using TravelAgency.Factory.Types;

namespace TravelAgency.Visitor
{
    interface IVisitor
    {
        void Visit(Order order);
    }
}
