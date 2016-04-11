using System;
class DeclareACharacter
{
    static void Main()
        //72dec = 48hex = character H
    {
        int i = 72;
        Console.Write("{0:X} hex is: ", i);
        char p = '\u0048';
        Console.Write(p);
        Console.WriteLine();
    }
}