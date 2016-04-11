﻿using System;
using Problem1.Shapes.Contracts;

namespace Problem1.Shapes.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative number!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative number!");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}