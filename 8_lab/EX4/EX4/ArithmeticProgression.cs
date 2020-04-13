using System;
using System.Collections.Generic;
using System.Text;

namespace EX4
{
    class ArithmeticProgression : IProgression
    {
        public double Razn;
        public double First;

        public ArithmeticProgression(double F, double R)
        {
            First = F;
            Razn = R;
        }

        public double GetElement(int Nomer)
        {
            return First + Razn * (Nomer - 1);
        }
    }
}
