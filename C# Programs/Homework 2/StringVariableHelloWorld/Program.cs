using System;
class StingVariableHelloWorld
{
    static void Main()
    {
        string h = "Hello";
        string w = "World";
        object hw = h + " " + w;
        string full = (hw.ToString());
        Console.WriteLine(full);
    }
}