using System;

class Program
{
    static void Main()
    {
        Console.Write("Please, enter your hexadecimal number (whitout spaces): ");
        string input = Console.ReadLine();
        Console.WriteLine(Convert.ToString(Convert.ToInt64(input, 16), 2));
    }
}

