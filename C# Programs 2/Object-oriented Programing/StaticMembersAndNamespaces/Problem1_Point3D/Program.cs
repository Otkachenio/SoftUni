using System;

namespace Problem1_Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(-7, -4, 3);
            Point3D secondPoint = new Point3D(17, 6, 2.5);

            Path path = new Path(firstPoint, secondPoint, Point3D.StartCordinates);

            Console.WriteLine(path);

            path.WriteToFile("../../test.txt");

            Path test = Path.ReadFromFile("../../test.txt");

            Console.WriteLine(test);
        }
    }
}