using System;

class Program
{
    static void Main()
    {
        Console.Write("Please, enter the year: ");
        int year = int.Parse(Console.ReadLine());
            
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine($"{year} is leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is NOT a leap year");
        }
    }
}

