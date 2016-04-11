using System;

class Program
{
    static void Main()
    {
        decimal builders = decimal.Parse(Console.ReadLine());
        decimal receptionists = decimal.Parse(Console.ReadLine());
        decimal chambermaids = decimal.Parse(Console.ReadLine());
        decimal technicians = decimal.Parse(Console.ReadLine());
        decimal others = decimal.Parse(Console.ReadLine());
        decimal NikiSalary = decimal.Parse(Console.ReadLine());
        decimal USACurrency = decimal.Parse(Console.ReadLine());
        decimal mySalary = decimal.Parse(Console.ReadLine());
        decimal buget = decimal.Parse(Console.ReadLine());
        decimal allMoney;
        decimal needed;
        decimal left;

        builders *= 1500.04m;
        receptionists *= 2102.10m;
        chambermaids *= 1465.46m;
        technicians *= 2053.33m;
        others *= 3010.98m;
        NikiSalary *= USACurrency;

        allMoney = builders + receptionists + chambermaids + technicians + others + NikiSalary + mySalary;

        if (allMoney > buget)
        {
            needed = allMoney - buget;
            Console.WriteLine("The amount is: {0:F2} lv.", allMoney);
            Console.WriteLine("NO \\ Need more: {0:F2} lv.", needed);
        }
        else
        {
            left = buget - allMoney;
            Console.WriteLine("The amount is: {0:F2} lv.", allMoney);
            Console.WriteLine("YES \\ Left: {0:F2} lv.", left);
        }
    }
}