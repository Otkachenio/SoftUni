using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int n = 10;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rnd.Next(100, 201));
        } 
    }
}
