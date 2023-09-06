using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosePrinciple
{
    // Rectangle class
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
