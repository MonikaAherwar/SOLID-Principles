using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitutionPrinciple
{
    public class LiskovSubstitutionPrinciple
    {
        public LiskovSubstitutionPrinciple()
        {
            Console.WriteLine("**************** DEFINITION ********************");
            Console.WriteLine("\r\nThe Liskov Substitution Principle (LSP) states that " +
                "objects of a derived class should be able to replace objects of the base class without affecting the correctness of the program." +
                " In other words, if a class is a subtype of another class, it should be usable interchangeably with its base class without causing issues.");
            Console.WriteLine("");
        }

        public void Problem()
        {
            Console.WriteLine("**************** PROBLEM ***********************");
            Console.WriteLine("Derived class (Ostrich) to be used interchangeably with an instance of the base class (Bird) without causing issues");
            Console.WriteLine("");
        }

        public void Solution()
        {
            Console.WriteLine("**************** SOLUTION **********************");
            Console.WriteLine("Derived class (Ostrich) to be used interchangeably with an instance of the base class (Bird) without causing issues");
            Console.WriteLine("");
        }
    }
}
