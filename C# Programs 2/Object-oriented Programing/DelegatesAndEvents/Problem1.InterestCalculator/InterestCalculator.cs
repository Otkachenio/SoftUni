namespace Problem1.InterestCalculator
{
    using System;

    class InterestCalculator
    {
        private decimal sum;
        private decimal interest;
        private int years;

        public InterestCalculator(decimal sum, decimal interest, int years,
            Func<decimal, decimal, int, decimal> interestCalculation)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.TotalSum = interestCalculation(sum, interest, years);
        }

        public decimal Sum
        {
            get
            {
                return this.sum;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The sum must be greater than 0!");
                }

                this.sum = value;
            }
        }

        public decimal Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The sum must be greater than 0!");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The year must be greater than 0!");
                }

                this.years = value;
            }
        }

        public decimal TotalSum { get; set; }

        public override string ToString()
        {
            return string.Format("Sum: {0}, Interest: {1}%, Years: {2}, Result: {3:F4}",
                                        this.Sum, this.Interest, this.Years, this.TotalSum);
        }
    }
}