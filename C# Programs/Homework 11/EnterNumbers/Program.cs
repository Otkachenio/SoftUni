using System;

class Program
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        int checkValue = 0;
        int[] array = new int[10];
        int n = 0; ;
        int count = 0;
        while (count < 10)
        {
            Console.Write("Please, enter a number: ");
            n = ReadNumber(start, end, n);
            if (checkValue < n && n <= end)
            {
                array[count] = n;
                count++;
                if (n == end)
                {
                    break;
                }
                checkValue = n;
            }
            else if (checkValue > n)
            {
                Console.WriteLine("You entered smallar number!");
            }
        }
        Console.Write("Yout numbers are: ");
        foreach (var num in array)
        {
            if (num > 0)
            {
                Console.Write($"{num} ");
            }
        }
        Console.WriteLine();
    }
    private static int ReadNumber(int start, int end, int n)
    {
        try
        {
            n = int.Parse(Console.ReadLine());
            if (n < start)
            {
                Console.WriteLine("The number is to small (smallar than \"start value\")");
            }
            else if (n > end)
            {
                Console.WriteLine("The number is to big (bigger than \"end value\")");
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR: Idex out of range (bigger than int range)");
        }
        catch (FormatException)
        {
            Console.WriteLine("ERROR: Idex not in correct format (not an integer)");
        }
        return n; 
    }
}

