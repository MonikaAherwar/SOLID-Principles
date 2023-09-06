using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosePrinciple
{
    // Drawing class
    public class Drawing
    {
        private readonly List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public double CalculateTotalArea()
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area();
            }
            return totalArea;
        }
    }
}
