using System;


namespace CheckIfBit3Is1Or0
{
    class Program
    {
        static void Main()
        {
            //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
            bool is3Digit1 = false;
            int number;
            Console.Write("Enter a number: ");
            bool itsValid = int.TryParse(Console.ReadLine(), out number);
            if (itsValid)
            {
                Console.Write("Number in bits: ");
                Console.WriteLine(Convert.ToString(number, 2));
                if ((number & 8) == 8)
                {
                    is3Digit1 = true;
                }
                Console.WriteLine("Is the third bit equal to 1?: {0}", is3Digit1);
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }

        }
    }
}
