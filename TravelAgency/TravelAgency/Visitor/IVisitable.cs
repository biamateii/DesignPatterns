namespace TravelAgency.Visitor
{
    interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
