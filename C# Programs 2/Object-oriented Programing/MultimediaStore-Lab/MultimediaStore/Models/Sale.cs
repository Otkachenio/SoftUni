namespace MultimediaStore.Models
{
    using System;
    using MultimediaStore.Interfaces;

    public class Sale : ISale
    {
        private IItem item;

        public Sale(IItem item, DateTime saleDate)
        {
            this.SaleDate = saleDate;
            this.Item = item;
        }

        public Sale(IItem item) : this(item, DateTime.Now)
        {
        }

        public IItem Item
        {
            get { return this.item; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Item cannot be null!");
                }

                this.item = value;
            }
        }

        public DateTime SaleDate { get; set; }

        public override string ToString()
        {
            string result = String.Format(" - {0} {1}\n{2}",
                this.GetType().Name, this.SaleDate, this.Item);

            return result;
        }
    }
}