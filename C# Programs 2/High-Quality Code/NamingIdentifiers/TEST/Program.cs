using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string gameTitle = "begin";
        int saleValue = 100;

        StreamWriter write = new StreamWriter(@"..\..\test.txt");
        write.WriteLine(gameTitle + " === " + string.Format("{0:C}", saleValue));
    }
}