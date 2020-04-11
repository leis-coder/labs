using System;
using System.Collections.Generic;
using System.Text;

namespace EX3
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public bool JustChecking()
        {
            double A = a;
            double B = b;
            double C = c;
            if ((A + B - C) < 0 | (A + C - B) < 0 | (B + C - A) < 0 | (A <= 0) | (B <= 0) | (C <= 0))
                return false;
            else
                return true;
        }
        public void ShowSides()
        {
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
        }
        public double Perimetr()
        {
            return a + b + c;
        }
        public double Area()
        {
            double p = this.Perimetr() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    
}
