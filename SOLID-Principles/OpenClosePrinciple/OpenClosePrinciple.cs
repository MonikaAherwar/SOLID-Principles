using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosePrinciple
{
    internal class OpenClosePrinciple
    {
        public OpenClosePrinciple()
        {
            Console.WriteLine("**************** DEFINITION ********************");
            Console.WriteLine("The Open/Closed Principle (OCP) states that software entities (classes, modules, functions) should be open for extension but closed for modification. " +
                "This means you should be able to extend the behavior of a class without changing its existing source code.");
            Console.WriteLine("");
        }

        public void Problem()
        {
            Console.WriteLine("**************** PROBLEM ***********************");
            Console.WriteLine("Modifying the same class/function to add the new features");
            Console.WriteLine("");
        }

        public void Solution()
        {
            Console.WriteLine("**************** SOLUTION **********************");
            Console.WriteLine("Use abstraction and inheritance to achieve this");
            Console.WriteLine("");
        }

        /*
         * The Drawing class contains a list of Shape objects 
         * and can calculate the total area of all shapes added to it 
         * without knowing the specific shape types.
         * A new shape can be added easily
        */
    }
}
