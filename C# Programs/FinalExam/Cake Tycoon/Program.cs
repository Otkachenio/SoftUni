using System;
class Program
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        uint f = uint.Parse(Console.ReadLine());
        uint t = uint.Parse(Console.ReadLine());
        uint p = uint.Parse(Console.ReadLine());
        double price;

        if ((n * c) > f)
        {
            double cakes;
            cakes = f / c;
            c = (n * c) - f;
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", Math.Floor(cakes), c);
        }
        else
        {
            price = ((double)p * t) / n * 1.25;
            Console.WriteLine("All products available, price of a cake: {0:F2}", price);
        }
    }
}