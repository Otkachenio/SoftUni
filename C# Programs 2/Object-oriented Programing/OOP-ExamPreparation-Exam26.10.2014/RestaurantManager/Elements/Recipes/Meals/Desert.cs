namespace RestaurantManager.Elements.Recipes.Meals
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Dessert : Meal, IDessert
    {
        private bool withSugar;

        public Dessert(string name, decimal price, int calories, int quantityPerServing,
           int timeToPrepare, bool isVegan, bool withSugar = true)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.WithSugar = withSugar;
        }

        public bool WithSugar
        {
            get
            {
                return this.withSugar;
            }

            private set
            {
                this.withSugar = value;
            }
        }

        public void ToggleSugar()
        {
            this.withSugar = !this.withSugar;
        }

        public override string ToString()
        {
            StringBuilder desertAsString = new StringBuilder();

            desertAsString.AppendLine(string.Format("{0}{1}==  {2} == ${3:F2}",
                this.WithSugar ? "" : "[NO SUGAR] ", this.IsVegan ? "[VEGAN] " : "",
                this.Name, this.Price));
            desertAsString.AppendLine(string.Format("Per serving: {0} g, {1} kcal", 
                this.QuantityPerServing, this.Calories));
            desertAsString.AppendLine(string.Format("Ready in {0} minutes", this.TimeToPrepare));

            return desertAsString.ToString();
        }
    }
}