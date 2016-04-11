using System;

namespace Problem1.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException("Number cannot be negative!");
                }
                double sqrt = Math.Sqrt(number);

                Console.WriteLine("Square root of {0} = {1}", number, sqrt);
            }
            catch (ArgumentException ae)
            {
                Console.Error.WriteLine("Not a valid number!" + "\r\n" + ae);
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Not a valid number!" + "\r\n" + fe);
            }
            catch (OverflowException of)
            {
                Console.Error.WriteLine("Not a valid number!" + "\r\n" + of);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}