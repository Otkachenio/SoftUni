using System;

namespace Problem4.CompanyHierarchy
{
    class Sales
    {
        private string productName;
        private decimal price;

        public Sales(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Product name cannot be less than 2 chars long!");
                }

                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public decimal Price
        {
            get { return this.price; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative number!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("Sale product: {0} ; Price: {1}$ ; -=- Date {2}",
                                                        this.productName, this.price, this.Date.Date);

            return result;
        }
    }
}