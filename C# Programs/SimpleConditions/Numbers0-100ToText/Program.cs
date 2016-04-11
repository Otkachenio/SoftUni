using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int ones = 0;

        string[] numbers0to20 = new string[] { "zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
            "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        string[] tens = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty",
                                        "seventy", "eighty", "ninety" };

        if (number < 0)
        {
            Console.WriteLine("invalid number");
        }

        else if (number < 20)
        {
            Console.WriteLine(numbers0to20[number]);
        }
        else if (number < 100)
        {
            ones = number % 10;
            number = number / 10;
            Console.Write(tens[number - 2]);
            if (ones > 0)
            {
                Console.WriteLine(" " + numbers0to20[ones]);
            }
            else
            {
                    Console.WriteLine();
            }
        }
        else if (number == 100)
        {
            Console.WriteLine("one hundred");
        }
        else
        {
            Console.WriteLine("invalid number");
        }
    }
}