using System;
using System.Collections.Generic;
using System.Text;

namespace EX6
{
    class GeometricProgression : Progression
    {
        public double Mnoj;
        public double First;

        public GeometricProgression(double F, double M)
        {
            First = F;
            Mnoj = M;
        }

        public override double GetElement(int Nomer)
        {
             return First * (Math.Pow(Mnoj, Nomer - 1));
        }
    }
}
