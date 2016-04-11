using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter rows and colums separeded by space: ");
        string[] tokens = Console.ReadLine().Split(' ');
        int a, b;
        bool checkA = int.TryParse(tokens[0], out a);
        bool checkB = int.TryParse(tokens[1], out b);

        if (checkA && checkB && a > 0 && b > 0)
        {
            string[,] matrix = new string[a, b];
            matrix = Matrix(a, b, matrix);
            PrintMatrix(matrix);
        }
        else
        {
            Console.WriteLine("Not a valid entry: Enter only positive integer numbers bigger than 0!!!");
        } 
    }

    public static string[,] Matrix(int a, int b, string[,] matrix)
    {
        char first = 'a';
        char second = 'a';
        char third = 'a';

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = first + "" + second + "" + third + " ";
                second++;
            }
            second = first;
            first++;
            second++;
            third++;
        }

        return matrix;
    }

    public static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}