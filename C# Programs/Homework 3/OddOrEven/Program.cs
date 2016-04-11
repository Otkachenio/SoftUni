using System;
class OddOrEven
{
    static void Main()
    {
        int number;
        Console.Write("Enter a number: ");
        bool isInt = int.TryParse(Console.ReadLine(), out number);
        if (isInt)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}
