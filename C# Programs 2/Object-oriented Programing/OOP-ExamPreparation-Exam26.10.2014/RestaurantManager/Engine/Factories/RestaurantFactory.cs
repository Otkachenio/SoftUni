namespace RestaurantManager.Engine.Factories
{
    using RestaurantManager.Interfaces.Engine;
    using RestaurantManager.Elements;

    public class RestaurantFactory : IRestaurantFactory
    {
        public Interfaces.IRestaurant CreateRestaurant(string name, string location)
        {
            return new Restaurant(name, location);
        }
    }
}