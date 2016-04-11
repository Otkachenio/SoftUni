using System;
class NullValuesAssignment
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("{0}\n{1}", i, d);
        i = 5;
        Console.WriteLine(i);
        d = 10;
        Console.WriteLine(d);
        i = i + 50;
        d = d + 100;
        Console.WriteLine("{0}\n{1}", i, d);

    }
}
