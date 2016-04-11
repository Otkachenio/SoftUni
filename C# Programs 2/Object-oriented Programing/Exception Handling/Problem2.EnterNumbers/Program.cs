using System;

namespace Problem2.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            int[] numbers = new int[10];
            int count = 1;
            int number = ReadNumber(start, end);

            numbers[0] = number;

            while (count < 10 && number < end)
            {
                number = ReadNumber(start, end);

                if (numbers[count - 1] < number)
                {
                    numbers[count] = number;
                    count++;
                }       
                else
                {
                    Console.WriteLine("Not a valid number, enter number bigger than {0} " +
                        "and smallar then {1}", numbers[count - 1], end);
                }        
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        public static int ReadNumber(int start, int end)
        {
            int number = 0;
            try
            {
                while (true)
                {
                    number = int.Parse(Console.ReadLine());
                    if (number >= start && number <= end)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Enter valid number in range {0} - {1}", start, end);
                    }
                }            
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

            return number;
        }
    }
}