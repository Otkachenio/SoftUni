using System;

class Program
{
    static void Main()
    {
        int dailyExpenses = int.Parse(Console.ReadLine());
        string path = Console.ReadLine();
        int extraMoney = 0, allEarnings = 0;
        int days = 0;

        while (path != "Season Over")
        {
            days++;
            int herbs = 0;
            string[] splited = path.Split(new char[0]);
            int hours = int.Parse(splited[0]);
            string dayPath = splited[1];
            int price = int.Parse(splited[2]);
            
            if (splited[1].Length < hours)
            {
                string H = splited[1];
                string dSplited = splited[1] + splited[1];
                for (int i = 0; i < hours; i++)
                {
                    if (dSplited[i] == 'H')
                    {
                        herbs++;
                    }
                }
            }
            else
            {
                string H = splited[1];
                for (int i = 0; i < hours; i++)
                {
                    if (H[i] == 'H')
                    {
                        herbs++;
                    }
                }
            }
            allEarnings += (herbs * price);
            path = Console.ReadLine();
        }

        if (allEarnings >= (dailyExpenses * days))
        {
            extraMoney = (allEarnings / days) - dailyExpenses;
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", extraMoney);
        }
        else
        {
            extraMoney = (dailyExpenses * days) - allEarnings;
            Console.WriteLine("We are in the red. Money needed: {0}.", extraMoney);
        }
        path = Console.ReadLine();
    }
}

