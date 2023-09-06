using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsibilityPrinciple
{
    public class SingleResponsibilityPrinciple
    {
        public SingleResponsibilityPrinciple()
        {
            Console.WriteLine("**************** DEFINITION ********************");
            Console.WriteLine("The Single Responsibility Principle (SRP) states that a class should have only one reason to change, " +
                "meaning it should have only one responsibility. " +
                "In other words, a class should do one thing and do it well. ");
            Console.WriteLine("");
        }

        public void Problem()
        {
            Console.WriteLine("**************** PROBLEM ***********************");
            Console.WriteLine("Multiple responsibilities on single class");
            Console.WriteLine("");
        }

        public void Solution()
        {
            Console.WriteLine("**************** SOLUTION **********************");
            Console.WriteLine("Atomic responsibility to each class");
            Console.WriteLine("");
        }

    }
}
