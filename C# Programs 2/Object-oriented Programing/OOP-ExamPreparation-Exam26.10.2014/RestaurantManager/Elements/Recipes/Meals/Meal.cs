namespace RestaurantManager.Elements.Recipes.Meals
{   
    using RestaurantManager.Models;
    using RestaurantManager.Interfaces;

    public abstract class Meal : Recipes, IMeal
    {
        private bool isVegan;
        public Meal(
            string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare, MetricUnit.Grams)
        {
            this.IsVegan = isVegan;
        }

        public bool IsVegan
        {
            get
            {
                return this.isVegan;
            }

            private set
            {
                this.isVegan = value;
            }
        }

        public void ToggleVegan()
        {
            this.isVegan = !this.isVegan;
        }
    }
}