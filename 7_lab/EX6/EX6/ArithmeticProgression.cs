using System;
using System.Collections.Generic;
using System.Text;

namespace EX6
{
    class ArithmeticProgression:Progression
    {
        public double Razn;
        public double First;

        public ArithmeticProgression(double F, double R)
        {
            First = F;
            Razn = R;
        }

        public override double GetElement(int Nomer)
        {
            return First + Razn * (Nomer - 1);
        }
    }
}
