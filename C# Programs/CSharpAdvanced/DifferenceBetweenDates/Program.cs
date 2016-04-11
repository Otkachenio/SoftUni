using System;

class Program
{
    static void Main(string[] args)
    {
        string firstDateInput = Console.ReadLine();
        DateTime firstDate = Convert.ToDateTime(firstDateInput);
        string secondDateInput = Console.ReadLine();
        DateTime secondDate = Convert.ToDateTime(secondDateInput);

        double TotalDays = (secondDate - firstDate).TotalDays;

        Console.WriteLine(TotalDays);
    }
}