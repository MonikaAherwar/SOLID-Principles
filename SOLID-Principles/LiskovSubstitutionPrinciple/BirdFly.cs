using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitutionPrinciple
{
    internal class BirdFly
    {
        internal static void MakeBirdFly(Bird bird)
        {
            bird.Fly();
        }

    }
}
