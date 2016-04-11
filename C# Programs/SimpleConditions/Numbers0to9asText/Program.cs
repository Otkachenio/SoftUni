using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> array = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int input = int.Parse(Console.ReadLine());

        if (input <= 9)
        {
            Console.WriteLine(array[input-1]);
        }
        else
        {
            Console.WriteLine("number too big");
        }
    }
}