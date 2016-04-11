using System;

namespace Problem1.Shapes.Shapes
{
    class Triangle : BasicShape
    {
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC) : base(sideA, sideB)
        {
            this.SideC = sideC;
        }

        public double SideC
        {
            get { return this.sideC; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("C cannot be negative!");
                }

                this.sideC = value;

                if (Width + Height <= this.sideC)
                {
                    throw new ArgumentException("Sum of the side lengths of any 2 sides of a triangle must exceed the length of the third side!");
                }
                if (this.sideC + Height <= Width)
                {
                    throw new ArgumentException("Sum of the side lengths of any 2 sides of a triangle must exceed the length of the third side!");
                }
                if (Width + this.sideC <= Height)
                {
                    throw new ArgumentException("Sum of the side lengths of any 2 sides of a triangle must exceed the length of the third side!");
                }             
            }
        }

        public override double CalculateArea()
        {
            //p - half of the perimeter used in Heron's formula
            double p = (Width + Height + sideC) / 2; 
            double area = Math.Sqrt((p * (p - Width) * (p - Height) * (p - sideC)));

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (Width + Height + sideC);

            return perimeter;
        }

        public override string ToString()
        {
            string result = String.Format(
                "Triangle(A = {0}, B = {1}, C = {2}) -> Area = {3:F2} -> Perimeter = {4:F2}",
                Width, Height, this.SideC, this.CalculateArea(), this.CalculatePerimeter());

            return result;
        }
    }
}