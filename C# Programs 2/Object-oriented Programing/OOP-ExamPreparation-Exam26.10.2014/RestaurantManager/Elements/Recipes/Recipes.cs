namespace RestaurantManager.Elements.Recipes
{
    using System;

    using RestaurantManager.Interfaces;
    using Models;

    public abstract class Recipes : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;
        private MetricUnit unit;

        public Recipes(
            string name, decimal price, int calories, int quantityPerServing, int timeToPrepare,
            MetricUnit unit)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
            this.Unit = unit;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (String.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentNullException("The {0} is required", "Name");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The {0} must be positive", "Price");
                }

                this.price = value;
            }
        }

        public int Calories
        {
            get
            {
                return this.calories;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The {0} must be positive", "Calories");
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The {0} must be positive", "Quantity");
                }

                this.quantityPerServing = value;
            }
        }

        public int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The {0} must be positive", "TimeToPrepeare");
                }

                this.timeToPrepare = value;
            }
        }

        public MetricUnit Unit
        {
            get
            {
                return this.unit;
            }

            private set
            {
                this.unit = value;
            }
        }    
    }
}