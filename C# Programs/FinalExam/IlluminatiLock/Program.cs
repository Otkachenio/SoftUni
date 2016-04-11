using System;

class Program
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        int p = 0;

        Console.WriteLine("{0}{1}{0}", new string ('.',n), new string ('#', n));
        Console.WriteLine("{0}###{0}###{0}", new string('.', n-2), new string('#', n-2));
        for (int i = n - 4; i > 0; i-=2)
        {
            p += 2;
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', i), new string('.', p), new string('.', n - 2));
        }

        for (int i2 = 1 ; i2 < n - 2; i2 += 2)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', i2), new string('.', p), new string('.', n - 2));
            p -= 2;
        }
        Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2), new string('#', n - 2));
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));

    }
}

