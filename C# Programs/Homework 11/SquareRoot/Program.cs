using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter your number: ");

            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new Exception("Error: Invalid number (number can't be negative)!");
                }
                Console.WriteLine("Square root of {0} = {1}", n, Math.Sqrt(n));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Invalid number (bigger than \"int\" range)");
            }
            catch (FormatException)
            {
                Console.WriteLine("Eror: Invalid number (the entry isn't in corect format)");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
