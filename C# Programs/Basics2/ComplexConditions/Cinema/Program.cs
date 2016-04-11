using System;

class Program
{
    static void Main(string[] args)
    {
        string ProjectionType = Console.ReadLine();
        string[] projections = new string[] { "Premiere", "Normal", "Discount" };
        double rows = double.Parse(Console.ReadLine());
        double cols = double.Parse(Console.ReadLine());

        double maximumIncome = 0;

        if (ProjectionType == projections[0])
        {
            maximumIncome = rows * cols * 12;
        }

        else if (ProjectionType == projections[1])
        {
            maximumIncome = rows * cols * 7.50;
        }

        else if (ProjectionType == projections[2])
        {
            maximumIncome = rows * cols * 5;
        }

        Console.WriteLine("{0:F2} leva", maximumIncome);
    }
}