using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosePrinciple
{
    // Circle class
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
