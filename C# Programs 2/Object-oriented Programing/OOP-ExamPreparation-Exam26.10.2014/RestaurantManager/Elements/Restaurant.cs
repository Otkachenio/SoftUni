namespace RestaurantManager.Elements
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    using RestaurantManager.Interfaces;
    using RestaurantManager.Elements.Recipes.Meals;
    using RestaurantManager.Elements.Recipes.Drinks;

    public class Restaurant : IRestaurant
    {
        private string name;
        private string location;
        private List<IRecipe> recipes;

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            recipes = new List<IRecipe>();
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
                    throw new ArgumentNullException("Name", "Restaurant name cannot be empty.");
                }

                this.name = value;
            }
        }
        public string Location
        {
            get
            {
                return this.location;
            }

            private set
            {
                if (String.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentNullException("Name", "Restaurant location cannot be empty.");
                }

                this.location = value;
            }
        }      

        public IList<IRecipe> Recipes
        {
            get { return this.recipes; }

            private set
            {
                this.recipes.Add((IRecipe)value);
            }
        }

        public void AddRecipe(IRecipe recipe)
        {
            if (!recipes.Contains(recipe))
            {
                this.Recipes.Add(recipe);
            }           
        }       

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }
        public string PrintMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine(string.Format("***** {0} - {1} *****", this.Name, this.Location));

            if (recipes.Count == 0)
            {
                menu.Append("No recipes... yet  ");
            }
            else
            {
                int num = 0;

                foreach (var recipe in recipes)
                {
                    if (recipe is Drink)
                    {
                        if (num == 0)
                        {
                            menu.AppendLine("~~~~~ DRINKS ~~~~~");
                        }
                        menu.Append(recipe);
                        num++;
                    }                   
                }

                num = 0;
                foreach (var recipe in recipes)
                {
                    if (recipe is Salad)
                    {
                        if (num == 0)
                        {
                            menu.AppendLine("~~~~~ SALADS ~~~~~");
                        }
                        menu.Append(recipe);
                        num++;
                    }
                }

                num = 0;
                foreach (var recipe in recipes)
                {
                    if (recipe is MainCourse)
                    {
                        if (num == 0)
                        {
                            menu.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                        }
                        menu.Append(recipe);
                        num++;
                    }
                }

                num = 0;
                foreach (var recipe in recipes)
                {
                    if (recipe is Dessert)
                    {
                        if (num == 0)
                        {
                            menu.AppendLine("~~~~~ DESSERTS ~~~~~");
                        }
                        menu.Append(recipe);
                        num++;
                    }
                }
            }

            //Hack for removing the last empty row in menu
            menu.Length -= 2;

            return menu.ToString();
        }
    }
}