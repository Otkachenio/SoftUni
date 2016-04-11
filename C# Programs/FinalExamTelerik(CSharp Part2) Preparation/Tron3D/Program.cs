using System;

class Program
{
    static void Main()
    {
        string[] tokens = Console.ReadLine().Split(' ');
        int[] dimensions = new int[3];

        for (int i = 0; i < 3; i++)
        {
            dimensions[i] = int.Parse(tokens[i]);
        }

        int[,,] matrix3D = new int[dimensions[0], dimensions[1], dimensions[2]];


    }
}

