namespace Problem1.InterestCalculator
{
    using System;

    class Test
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, int, decimal> simple = GetSimpleInterest;
            Func<decimal, decimal, int, decimal> compound = GetCompoundIterest;

            var test1 = new InterestCalculator(500m, 5.6m, 10, compound);
            var test2 = new InterestCalculator(2500m, 7.2m, 15, simple);

            Console.WriteLine(test1);
            Console.WriteLine(test2);
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            decimal simpleInterest = sum * (1 + interest / 100 * years);

            return simpleInterest;
        }

        public static decimal GetCompoundIterest(decimal sum, decimal interest, int years)
        {
            // n is the number of times per year the interest is compounded
            int n = 12;
            decimal compoundInterest = sum * 
                (decimal)Math.Pow((double)(1 + (interest / 100) / n), (years * n));

            return compoundInterest;
        }
    }
}