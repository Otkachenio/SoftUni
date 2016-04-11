using System;

class Program
{
    static void Main(string[] args)
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int maxNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i < numbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (maxNumber < number)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine(maxNumber);
    }
}