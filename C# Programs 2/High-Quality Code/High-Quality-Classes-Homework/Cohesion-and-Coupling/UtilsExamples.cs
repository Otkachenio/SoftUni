using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(GetFileNameAndExtension.GetExtension("example"));
            Console.WriteLine(GetFileNameAndExtension.GetExtension("example.pdf"));
            Console.WriteLine(GetFileNameAndExtension.GetExtension("example.new.pdf"));
                              
            Console.WriteLine(GetFileNameAndExtension.GetName("example"));
            Console.WriteLine(GetFileNameAndExtension.GetName("example.pdf"));
            Console.WriteLine(GetFileNameAndExtension.GetName("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                DistanceCalculator.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                DistanceCalculator.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            DistanceCalculator.Width = 3;
            DistanceCalculator.Height = 4;
            DistanceCalculator.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", DistanceCalculator.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", DistanceCalculator.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", DistanceCalculator.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", DistanceCalculator.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", DistanceCalculator.CalculateDiagonalYZ());
        }
    }
}