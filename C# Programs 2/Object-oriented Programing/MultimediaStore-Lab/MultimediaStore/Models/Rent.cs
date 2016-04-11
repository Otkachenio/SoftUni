namespace MultimediaStore.Models
{
    using System;
    using System.Text;

    using MultimediaStore.Interfaces;
    
    public class Rent : IRent
    {
        private const int DefaultRentPeriodInDays = 30;
        private const decimal RentFinePerDay = 0.01m;

        private IItem item;

        public Rent(IItem item, DateTime rentDate, DateTime deadline)
        {
            this.Item = item;
            this.RentDate = rentDate;
            this.Deadline = deadline;
        }

        public Rent(IItem item, DateTime rentDate) 
            : this(item, rentDate, rentDate.AddDays(DefaultRentPeriodInDays))
        {
        }

        public Rent(IItem item) 
            : this (item, DateTime.Now, DateTime.Now.AddDays(DefaultRentPeriodInDays))
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

        

        public decimal RentFine
        {
            get
            {
                var date = this.IsSetDate(this.ReturnDate) ? this.ReturnDate : DateTime.Now;
                decimal fine = (date - this.Deadline).Days * this.Item.Price * RentFinePerDay;

                return Math.Max(fine, 0);
            }
        }     

        public RentState RentState
        {
            get
            {
                var now = DateTime.Now;

                if (this.IsSetDate(this.ReturnDate))
                {
                    return RentState.Returned;
                }
                else if (now > this.Deadline)
                {
                    return RentState.Overdue;
                }
                else
                {
                    return RentState.Pending;
                }
            }
        }

        public void ReturnItem()
        {
            this.ReturnDate = DateTime.Now;
        }

        public bool IsSetDate(DateTime dateTime)
        {
            return dateTime.Year > 1;
        }

        public DateTime RentDate { get; private set; }

        public DateTime Deadline { get; private set; }

        public DateTime ReturnDate { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(String.Format("- {0} {1}", this.GetType().Name, this.RentState));
            result.AppendLine(this.Item.ToString());
            result.AppendLine(String.Format("Rent fine: {0:F2}", this.RentFine));

            return result.ToString();
        }
    }
}