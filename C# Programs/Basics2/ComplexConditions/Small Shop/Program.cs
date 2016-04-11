using System;

class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string city = Console.ReadLine();
        double price = double.Parse(Console.ReadLine());

        string[] cyties = new string[] { "Sofia", "Plovdiv", "Varna" };

        string[] products = new string[] { "coffee", "water", "beer", "sweets", "peanuts" };

        double costs = 0;

        if (city == cyties[0])
        {
            if (product == products[0]) costs = price * 0.50;
            else if (product == products[1]) costs = price * 0.80;
            else if (product == products[2]) costs = price * 1.20;
            else if (product == products[3]) costs = price * 1.45;
            else if (product == products[4]) costs = price * 1.60;
        }

        else if (city == cyties[1])
        {
            if (product == products[0]) costs = price * 0.40;
            else if (product == products[1]) costs = price * 0.70;
            else if (product == products[2]) costs = price * 1.15;
            else if (product == products[3]) costs = price * 1.30;
            else if (product == products[4]) costs = price * 1.50;
        }

        else if (city == cyties[2])
        {
            if (product == products[0]) costs = price * 0.45;
            else if (product == products[1]) costs = price * 0.70;
            else if (product == products[2]) costs = price * 1.10;
            else if (product == products[3]) costs = price * 1.35;
            else if (product == products[4]) costs = price * 1.55;
        }

        Console.WriteLine(costs);
    }
}