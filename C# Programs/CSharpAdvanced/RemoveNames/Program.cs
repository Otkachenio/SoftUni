using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] tokensFRow = Console.ReadLine().Split(' ');
        string[] tokensSRow = Console.ReadLine().Split(' ');
        List<string> fRow = new List<string>();

        for (int i = 0; i < tokensFRow.Length; i++)
        {
            fRow.Add(tokensFRow[i]);
        }

        for (int i = 0; i < tokensSRow.Length; i++)
        {
            fRow.RemoveAll(s => s == tokensSRow[i]);
        }
        
        foreach (var item in fRow)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();     
    }
}