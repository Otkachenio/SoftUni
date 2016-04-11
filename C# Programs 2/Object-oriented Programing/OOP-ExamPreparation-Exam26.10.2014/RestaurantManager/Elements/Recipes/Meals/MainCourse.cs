namespace RestaurantManager.Elements.Recipes.Meals
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;
    using Models;

    public class MainCourse : Meal, IMainCourse
    {
        private MainCourseType type;

        public MainCourse(string name, decimal price, int calories, int quantityPerServing,
            int timeToPrepare, bool isVegan, string type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = MainCourseParser(type);
        }

        public MainCourseType Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                this.type = value;
            }
        }

        private MainCourseType MainCourseParser(string typeAsString)
        {
            switch (typeAsString)
            {
                case "Pasta":
                    return MainCourseType.Pasta;
                case "Soup":
                    return type = MainCourseType.Soup;
                case "Entree":
                    return MainCourseType.Entree;                    
                case "Side":
                    return MainCourseType.Side;
                case "Meat":
                    return MainCourseType.Meat;
                case "Other":
                    return MainCourseType.Other;
                default:
                    throw new ArgumentException("No such type");
            }
        }

        public override string ToString()
        {
            StringBuilder mainCourseAsString = new StringBuilder();
          
            mainCourseAsString.AppendLine(string.Format("{0}==  {1} == ${2:F2}", 
                this.IsVegan ? "[VEGAN] " : "", this.Name, this.Price));
            mainCourseAsString.AppendLine(string.Format("Per serving: {0} g, {1} kcal", 
                this.QuantityPerServing, this.Calories));
            mainCourseAsString.AppendLine(string.Format("Ready in {0} minutes", this.TimeToPrepare));
            mainCourseAsString.AppendLine(string.Format("Type: {0}", this.Type));

            return mainCourseAsString.ToString();
        }
    }
}