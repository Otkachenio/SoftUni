using System;
class Print
{
    static void Main ()
    {
        Console.WriteLine("What is your age");
        int age = Convert.ToInt16(Console.ReadLine());
        int futureAge = age + 10;
        Console.WriteLine("After 10 years you will be {0} years old.", futureAge);

    }
}
