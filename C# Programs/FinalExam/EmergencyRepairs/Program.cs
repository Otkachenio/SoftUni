using System;

class Program
{
    static void Main()
    {
        ulong baiIvanWall = ulong.Parse(Console.ReadLine());
        int emargancyRepairKits = int.Parse(Console.ReadLine());
        int numberOfAttacks = int.Parse(Console.ReadLine());
        int representingTheAtack = int.Parse(Console.ReadLine());
        ulong wall = 0;
        
        for (int i = 63; i >=0; i--)
        {
            wall += wall >> 1 | ((baiIvanWall << i) & 1);
            Console.WriteLine(wall);
        }
    }
}

