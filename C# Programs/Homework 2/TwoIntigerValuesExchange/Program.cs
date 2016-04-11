using System;
class ValueExchange
{
    static void Main()
    {
        //Two Ways
        // First Way
        int x = 5;
        int y = 10;
        x = x + y;
        y = x - y;
        x = x - y;
        Console.WriteLine("x={0}",x);
        Console.WriteLine("y={0}",y);
        Console.WriteLine();
        //Second Way
        int number1 = 5;
        int number2 = 10;
        Console.WriteLine("Before exchange \u2192 number1={0}\tnumber2={1}", number1, number2);
        int number3;
        number3 = number1;
        number1 = number2;
        number2 = number3;
        Console.WriteLine("After exchange \u2192 number1={0}\tnumber2={1}", number1, number2);
    }
}
