using System;
using SOLID_Principles.OpenClosePrinciple;
using SOLID_Principles.SingleResponsibilityPrinciple;

namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the parent project which demonstrate 'SOLID PRINCIPLES' in C# .NET");
            Console.WriteLine("");

            // Single Responsibility Principle
            SingleResponsibilityPrinciple.SingleResponsibilityPrinciple srp = new SingleResponsibilityPrinciple.SingleResponsibilityPrinciple();
            srp.Problem();
            srp.Solution();

            // Open Close Principle
            var drawing = new Drawing();
            drawing.AddShape(new Rectangle(5, 4));
            drawing.AddShape(new Circle(3));

            double totalArea = drawing.CalculateTotalArea();
            Console.WriteLine($"Total Area: {totalArea}");
        }
    }
}
