using System;
class QuotedStrings
{
    static void Main()
    {
        string a = "The \"use\" of quotatations causes difficulties";
        string b = @"The ""use"" of quotatations causes difficulties";
        Console.WriteLine("{0}\n{1}", a, b);
    }
}