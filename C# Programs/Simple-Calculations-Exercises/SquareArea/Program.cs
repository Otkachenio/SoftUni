using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        var a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Area = {a * a}");
    }
}

