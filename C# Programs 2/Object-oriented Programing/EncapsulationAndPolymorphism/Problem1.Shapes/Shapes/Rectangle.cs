using System;

namespace Problem1.Shapes.Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) : base(width, height) { }

        public override double CalculateArea()
        {
            double area = Width * Height;

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (2 * Width) + (2 * Height);

            return perimeter;
        }

        public override string ToString()
        {
            string result = String.Format("Rectange(W = {0}, H ={1}) -> Area = {2} -> Perimeter = {3}",
                Width, Height, this.CalculateArea(), this.CalculatePerimeter());

            return result;
        }
    }
}