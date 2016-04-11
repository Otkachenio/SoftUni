namespace RestaurantManager.Elements.Recipes.Meals
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Salad : Meal, ISalad
    {
        private const bool DefaultVeganValue = true;

        private bool containsPasta;

        public Salad(string name, decimal price, int calories, int quantityPerServing,
            int timeToPrepare, bool containsPasta = false)
            : base(name, price, calories, quantityPerServing, timeToPrepare, DefaultVeganValue)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta
        {
            get
            {
                return this.containsPasta;
            }

            private set
            {
                this.containsPasta = value;
            }
        }

        public override string ToString()
        {
            StringBuilder saladAsString = new StringBuilder();

            saladAsString.AppendLine(string.Format("[VEGAN] ==  {0} == ${1:F2}",
                this.Name, this.Price));
            saladAsString.AppendLine(string.Format("Per serving: {0} g, {1} kcal",
                this.QuantityPerServing, this.Calories));
            saladAsString.AppendLine(string.Format("Ready in {0} minutes", this.TimeToPrepare));
            saladAsString.AppendLine(string.Format("Contains pasta: {0}",
                this.ContainsPasta ? "yes" : "no"));

            return saladAsString.ToString();
        }
    }
}