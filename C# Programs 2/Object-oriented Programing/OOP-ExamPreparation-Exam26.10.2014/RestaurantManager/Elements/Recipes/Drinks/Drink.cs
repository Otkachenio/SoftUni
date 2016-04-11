namespace RestaurantManager.Elements.Recipes.Drinks
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;
    using Models;

    public class Drink : Recipes, IDrink
    {
        private bool isCarbonated;

        public Drink(string name, decimal price, int calories, int quantityPerServing,
            int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, timeToPrepare, MetricUnit.Milliliters)
        {
            this.IsCarbonated = isCarbonated;
            this.DrinkCalories = calories;
            this.DrinkTimeToPrepare = timeToPrepare;
        }

        public int DrinkCalories
        {
            get
            {
                return this.Calories;
            }

            private set
            {
                if (value > 100)
                {
                    throw new ArgumentException(
                        "The calories in a drink must not be greater than 100.");
                }

                this.Calories = value;
            }
        }

        public int DrinkTimeToPrepare
        {
            get
            {
                return this.TimeToPrepare;
            }

            private set
            {
                if (value > 20)
                {
                    throw new ArgumentException(
                        "The time to prepare a drink must not be greater than 20 minutes");
                }

                this.TimeToPrepare = value;
            }
        }

        public bool IsCarbonated
        {
            get
            {
                return this.isCarbonated;
            }

            private set
            {
                this.isCarbonated = value;
            }
        }

        public override string ToString()
        {
            StringBuilder drinksAsString = new StringBuilder();
         
            drinksAsString.AppendLine(string.Format("==  {0} == ${1:F2}", this.Name, this.Price));
            drinksAsString.AppendLine(string.Format("Per serving: {0} ml, {1} kcal",
                this.QuantityPerServing, this.Calories));
            drinksAsString.AppendLine(string.Format("Ready in {0} minutes", this.TimeToPrepare));
            drinksAsString.AppendLine(string.Format("Carbonated: {0}",
                this.isCarbonated ? "yes" : "no"));

            return drinksAsString.ToString(); ;
        }
    }
}