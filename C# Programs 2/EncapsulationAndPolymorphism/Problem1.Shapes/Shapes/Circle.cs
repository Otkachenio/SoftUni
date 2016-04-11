using System;
using Problem1.Shapes.Contracts;

namespace Problem1.Shapes.Shapes
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Radius cannot be negative number!");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI * (this.radius * this.radius);

            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = (2 * Math.PI) * this.radius;

            return perimeter;
        }

        public override string ToString()
        {
            string result = String.Format("Cicle(radius = {0}) -> Area = {1:F2} -> Perimeter {2:F2}",
                                    this.radius, this.CalculateArea(), this.CalculatePerimeter());

            return result;
        }
    }
}