using System;

class Program
{
    static void Main()
    {
        Console.Write("Please, enter your number (separeted by space):");
        string[] tokens = Console.ReadLine().Split(' ');
        int[] numbers = new int[tokens.Length];
        int sum = 0;

        for (int i = 0; i < tokens.Length; i++)
        {
            numbers[i] = int.Parse(tokens[i]);
        } 

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of your numbers is: {sum}");
    }
}

