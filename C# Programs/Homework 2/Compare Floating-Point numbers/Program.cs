using System;

public class FloatingPointNumbers
{
    public static void Main()
    {
        var first = decimal.Parse(Console.ReadLine());
        var second = decimal.Parse(Console.ReadLine());

        if (((second - first) == 0.000001m) || (first - second) == 0.000001m)
        {
            Console.WriteLine("Border case. The difference 0.000001 == eps. We consider the numbers are different.");
        }
        else if ((first * -1) == (second) || (first == (second * -1)) || (float)first == (float)second)
        {
            Console.WriteLine("The result is:  {0} The difference {1} < eps", true, (first - second) * -1);
        }
        else
        {
            Console.WriteLine("The result is:  {0} The difference of {1} is too big (> eps)", false, second - first);
        }
    }
}

