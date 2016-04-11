using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffling
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = Console.ReadLine();
                }
            }
            string[] command = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (!(command.Length == 1 && command[0] == "END"))
            {
                try
                {
                    if (command[0] == "swap" && command.Length == 5)
                    {
                        Swap(ref matrix, command[0], int.Parse(command[1]), int.Parse(command[2]), int.Parse(command[3]), int.Parse(command[4]));
                        PrintMatrix(matrix);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static void Swap(ref string[,] matrix, string cmd, int x1, int x2, int y1, int y2)
        {
            string temp = matrix[x1, x2];
            matrix[x1, x2] = matrix[y1, y2];
            matrix[y1, y2] = temp;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int pr = 0; pr < matrix.GetLength(0); pr++)
            {
                for (int pc = 0; pc < matrix.GetLength(1); pc++)
                {
                    Console.Write($"{matrix[pr,pc]} ".PadLeft(2, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
