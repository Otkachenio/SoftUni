using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string inputData = Console.ReadLine();
        DateTime input = DateTime.ParseExact(inputData, "dd-mm-yyyy", CultureInfo.InvariantCulture);
        string dataAsString = input.AddDays(1000).ToString();
        dataAsString = dataAsString.Replace(' ', '.');
        string[] arrayData = dataAsString.Split('.');
        string data = (arrayData[0] + "-" + arrayData[1] + "-" + arrayData[2]);
        Console.WriteLine(data);
    }
}