using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class Program
    {
        static void Main()
        {
            //Write a program that exchanges 
            //bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
            uint n;
            byte p, q, k;
            Console.Write("Please, enter your numer n: ");
            bool checkN = uint.TryParse(Console.ReadLine(), out n);
            Console.Write("Plese, enter the position of the first bit p: ");
            bool checkP = byte.TryParse(Console.ReadLine(), out p);
            Console.Write("Please, enter the position of the second bit q: ");
            bool checkQ = byte.TryParse(Console.ReadLine(), out q);
            Console.Write("Please, enter the lenght of the sequence k: ");
            bool checkK = byte.TryParse(Console.ReadLine(), out k);
            if (checkN && checkP && checkQ && checkK)
            {
                if ((p + k) < 31 && (q + k) < 31 && (Math.Abs(p - q) >= k))
                {
                    if (p > q)
                    {
                        byte temp = q;
                        q = p;
                        p = temp;
                    }
                    Console.WriteLine("binary initial n:");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

                    n = ((~(((uint)Math.Pow(2, k) - 1) << q | ((uint)Math.Pow(2, k) - 1) << p)) & n) | (((n & (((uint)Math.Pow(2, k) - 1) << p)) << (Math.Abs(p - q))) | ((n & (((uint)Math.Pow(2, k) - 1) << q)) >> (Math.Abs(p - q)))); //Swap bits p with bits q
                    Console.WriteLine("binary new n:");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                }
                else
                {
                    Console.WriteLine("Not a valid entry!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }
        }
    }
}
