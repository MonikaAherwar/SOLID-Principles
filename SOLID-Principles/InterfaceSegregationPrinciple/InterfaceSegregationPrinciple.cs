using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregationPrinciple
{
    internal class InterfaceSegregationPrinciple
    {
        public InterfaceSegregationPrinciple()
        {
            Console.WriteLine("**************** DEFINITION ********************");
            Console.WriteLine("The Interface Segregation Principle (ISP) states that " +
                "clients should not be forced to depend on interfaces they do not use. " +
                "In other words, it's better to have smaller, more specific interfaces " +
                "rather than a single large interface that contains methods unrelated to a client's needs.");
            Console.WriteLine("");
        }

        public void Problem()
        {
            Console.WriteLine("**************** PROBLEM ***********************");
            Console.WriteLine("One interface contains more responsibility");
            Console.WriteLine("");
        }

        public void Solution()
        {
            Console.WriteLine("**************** SOLUTION **********************");
            Console.WriteLine("Divide the interface into smaller interfaces to divide the responsibility");
            Console.WriteLine("");
        }

        public void Example()
        {
            Console.WriteLine("**************** EXAMPLE ***********************");
            Console.WriteLine("Refer Strategy Pattern Example");
            Console.WriteLine("");
        }
    }
}
