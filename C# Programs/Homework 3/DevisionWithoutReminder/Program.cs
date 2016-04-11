using System;
namespace DevisionWithoutReminder
{
    class Program
    {
        static void Main()
        {
            //Devided by 7 and 5 (35)
            int number;
            Console.WriteLine("Enter Your Number: ");
            bool isInt = int.TryParse(Console.ReadLine(), out number);
            if (isInt)
            {
                double x;
                x = (double)number / 35;
                if (x % 1 == 0)
                {
                    Console.WriteLine("TRUE \nThe number devides by 7 and 5 whithout reminder");
                }
                else
                {
                    Console.WriteLine("FALSE \nThe number doesn't devide by 7 and 5 without reminder");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry");
            }
        }
    }
}
