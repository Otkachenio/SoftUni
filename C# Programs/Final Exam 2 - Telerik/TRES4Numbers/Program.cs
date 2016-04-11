using System;
using System.Collections.Generic;

class TRESConverter
{
    static void Main()
    {
        string[] array = new string[] {"LON+", "VK-", "*ACAD" ,"^MIM", "ERIK|",
                                        "SEY&", "EMY>>","/TEL", "<<DON"};
        List<string> tres4number = new List<string>();

        ulong input = ulong.Parse(Console.ReadLine());

        ulong digit = 0;

        if (input == 0) Console.WriteLine(array[0]);

        while (input > 0)
        {
            digit = (input % 9);
            tres4number.Add(array[digit]);
            input = (input / 9);
        }
        tres4number.Reverse();
        
        foreach (var num in tres4number)
        {
            Console.Write(num);
        }
    }
}
