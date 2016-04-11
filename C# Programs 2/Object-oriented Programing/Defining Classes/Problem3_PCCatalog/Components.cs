using System;

namespace Problem3_PCCatalog
{
    class Component
    {
        private string model;
        private string details;
        private decimal price;

        public Component() { }

        public Component(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Component(string name, decimal price, string details) : this(name, price)
        {
            this.Details = details;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null!");
                }
                if (value.Trim().Length < 2)
                {
                    throw new ArgumentException("Name must be at least 2 chars long!");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be negative or zero!");
                }
                this.price = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                this.details = value;
            }
        }
    }
}