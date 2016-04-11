using System;

namespace CheckThirdDigit
{
    class Program
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Enter your number: ");
            bool itsNumber = int.TryParse(Console.ReadLine(), out number);
            if (itsNumber && number > 699)
            {
                if ((number / 100) % 10 == 7)
                {
                    Console.WriteLine("Third digit is 7");
                }
                else
                {
                    Console.WriteLine("Third digin ISN't 7");
                }
            }
            else
            {
                Console.WriteLine("Not a valid Entry, Please write a number bigger  than 699!");
            }
        }
    }
}
