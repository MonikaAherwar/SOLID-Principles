using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitutionPrinciple
{
    // Derived class
    class Ostrich : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("An ostrich cannot fly.");
        }

        public void Run()
        {
            Console.WriteLine("An ostrich can run fast.");
        }
    }
}
