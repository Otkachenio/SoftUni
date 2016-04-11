using Problem1.Shapes.Shapes;
using System;

namespace Problem1.Shapes
{
    class Test
    {
        static void Main(string[] args)
        {
            Circle[] circlesArray = new Circle[3];

            circlesArray[0] = new Circle(2.5);
            circlesArray[1] = new Circle(5);
            circlesArray[2] = new Circle(10);

            Console.WriteLine(circlesArray[0]);
            Console.WriteLine(circlesArray[1]);
            Console.WriteLine(circlesArray[2]);

            Console.WriteLine("--------------------------------------------");

            Rectangle[] rectanglesArray = new Rectangle[3];

            rectanglesArray[0] = new Rectangle(2.5, 5);
            rectanglesArray[1] = new Rectangle(5, 10);
            rectanglesArray[2] = new Rectangle(10, 20);

            Console.WriteLine(rectanglesArray[0]);
            Console.WriteLine(rectanglesArray[1]);
            Console.WriteLine(rectanglesArray[2]);

            Console.WriteLine("--------------------------------------------");

            Triangle[] trianglesArray = new Triangle[3];

            trianglesArray[0] = new Triangle(5, 5, 9);
            trianglesArray[1] = new Triangle(5, 10, 10);
            trianglesArray[2] = new Triangle(10, 18, 10);

            Console.WriteLine(trianglesArray[0]);
            Console.WriteLine(trianglesArray[1]);
            Console.WriteLine(trianglesArray[2]);
        }
    }
}
