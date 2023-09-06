using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitutionPrinciple
{
    using System;

    // Base class
    class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("A bird can fly.");
        }
    }
}
