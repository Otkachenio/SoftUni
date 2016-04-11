using System;

class Program
{
    static void Main()
    {
        decimal b, r, c, t, o; // Builders, Receptionists, Chambermaids, Technicians Others
        decimal n, u, s, m; // Niki, USACurency, MySlalary, Budget 
        decimal allMoney;
        decimal needed;
        decimal left;

        b = decimal.Parse(Console.ReadLine());
        r = decimal.Parse(Console.ReadLine());
        c = decimal.Parse(Console.ReadLine());
        t = decimal.Parse(Console.ReadLine());
        o = decimal.Parse(Console.ReadLine());
        n = decimal.Parse(Console.ReadLine());
        u = decimal.Parse(Console.ReadLine());
        s = decimal.Parse(Console.ReadLine());
        m = decimal.Parse(Console.ReadLine());

        b *= 1500.04m;
        r *= 2102.10m;
        c *= 1465.46m;
        t *= 2053.33m;
        o *= 3010.98m;
        n *= u;

        allMoney = b + r + c + t + o + n + s;

        if (allMoney > m)
        {
            needed = allMoney - m;
            Console.WriteLine("The amount is: {0:F2} lv.", allMoney);
            Console.WriteLine("NO \\ Need more: {0:F2} lv.", needed);
        }
        else
        {
            left = m - allMoney;
            Console.WriteLine("The amount is: {0:F2} lv.", allMoney);
            Console.WriteLine("YES \\ Left: {0:F2} lv.", left);
        }
    }
}