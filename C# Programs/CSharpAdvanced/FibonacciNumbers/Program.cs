using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibN;
            int a = 1, b = 1;
            bool checkFibN = int.TryParse(Console.ReadLine(), out fibN);

            if (checkFibN && fibN >= 0)
            {
                if (fibN == 0 || fibN == 1)
                {
                    Console.WriteLine("The {0} Fibonacci number is: 1", fibN);
                }
                else
                {
                    for (int i = 1; i <= fibN; i++)
                    {
                        int temp = a;
                        a = b;
                        b = temp + b;
                    }
                    Console.WriteLine("The {0} Fibonacci number is: {1}", fibN, a);
                }
            }
            else
            {
                Console.WriteLine("Not a valid Entry, only integers bigger than zero!!!");
            }
        }
    }
}
