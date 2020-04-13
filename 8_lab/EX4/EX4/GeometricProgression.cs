using System;
using System.Collections.Generic;
using System.Text;

namespace EX4
{
    class GeometricProgression
    {
        public double Mnoj;
        public double First;

        public GeometricProgression(double F, double M)
        {
            First = F;
            Mnoj = M;
        }

        public double GetElement(int Nomer)
        {
            return First * (Math.Pow(Mnoj, Nomer - 1));
        }
    }
}
