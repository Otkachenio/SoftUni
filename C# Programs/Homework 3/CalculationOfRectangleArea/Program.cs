using System;
namespace CalculationOfRectangleArea
{
    class PrProgram
    {
        static void Main()
        {
            decimal Height;
            decimal Width;
            Console.Write("Enter Height: ");
            bool ValidHeight = decimal.TryParse(Console.ReadLine(), out Height);
            Console.Write("Enter Width: ");
            bool ValidWidth = decimal.TryParse(Console.ReadLine(), out Width);
            if (ValidHeight && ValidWidth)
            {
            decimal Area = Height * Width;
            Console.WriteLine("The Area of the Rectangle is: {0}", Area);   
            }
            else
            {
                Console.WriteLine("Not a valid Entry!!!");
            }
        }
    }
}

//Console.Write("Enter the Hight: ");
//decimal Height = decimal.Parse(Console.ReadLine());
//Console.Write("Enter the Width: ");
//decimal Width = decimal.Parse(Console.ReadLine());
//decimal Area = Height * Width;
//Console.WriteLine("The Area of the Rectangle is: {0}", Area);