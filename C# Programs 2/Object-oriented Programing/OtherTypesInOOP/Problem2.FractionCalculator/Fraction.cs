namespace Problem2.FractionCalculator
{
    using System;

    public struct Fraction
    {
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Denominator
        {
            get { return this.denominator; }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Cannot devide by zero!");
                }

                this.denominator = value;   
            }             
        }

        public long Numerator { get; set; }

        public static Fraction operator +(Fraction firstFraction, Fraction secondFraction)
        {
            firstFraction.Numerator *= secondFraction.Denominator;
            secondFraction.Numerator *= firstFraction.Denominator;
            long generalNumerator = firstFraction.Numerator + secondFraction.Numerator;

            long generalDominator = firstFraction.Denominator * secondFraction.Denominator;

            return new Fraction(generalNumerator, generalDominator);
        }

        public static Fraction operator -(Fraction firstFraction, Fraction secondFraction)
        {
            firstFraction.Numerator *= secondFraction.Denominator;
            secondFraction.Numerator *= firstFraction.Denominator;
            long generalNumerator = firstFraction.Numerator - secondFraction.Numerator;

            long generalDominator = firstFraction.Denominator * secondFraction.Denominator;

            return new Fraction(generalNumerator, generalDominator);
        }
    
        public decimal Result()
        {
            decimal result = (decimal)this.Numerator / this.Denominator;

            return result;
        }

        public override string ToString()
        {
            string resultString = String.Format("{0}", this.Result());

            return resultString;
        }
    }
}