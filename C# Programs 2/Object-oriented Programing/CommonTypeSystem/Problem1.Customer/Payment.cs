namespace Problem1.Customer
{
    using System;

    public class Payment
    {
        private string productName;
        private decimal productPrice;

        public Payment(string productName, decimal productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if (String.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentException("Product name cannot be empty!");
                }

                this.productName = value;
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return this.productPrice;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }

                this.productPrice = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("{0} - {1:F2}$", this.productName, this.productPrice);

            return result;
        }
    }
}