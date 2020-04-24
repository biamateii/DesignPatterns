namespace TravelAgency.Factory
{
    abstract class UserFactory
    {

        public abstract User GetUser(string username, string password);
    }
}
