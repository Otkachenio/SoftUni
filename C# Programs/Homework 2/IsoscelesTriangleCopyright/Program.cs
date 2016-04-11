using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        //00A9 - unicode symbol for Copyright wich doesn't work :(
        Console.OutputEncoding = Encoding.UTF8;
        char c = '\u00A9';
        Console.WriteLine("     " +c);
        Console.WriteLine("    " +c+c);
        Console.WriteLine("   " +c+"  "+c);
        Console.WriteLine("  " +c+"    "+c);
        Console.WriteLine(" " + c + "      " + c);
        Console.WriteLine("{0}{1}{2}{3}{4}{5}",c,c,c,c,c,c);
    }
}