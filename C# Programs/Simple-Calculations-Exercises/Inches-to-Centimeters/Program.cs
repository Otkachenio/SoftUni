using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter inches: ");
        var inc = double.Parse(Console.ReadLine());
        var cm = inc * 2.54;
        Console.WriteLine(cm);
    }
}