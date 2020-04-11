using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, third;
            Console.Write("a = ");
            first = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            second = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            third = double.Parse(Console.ReadLine());

            Console.Clear();

            Triangle T1 = new Triangle(first, second, third);
            if (T1.JustChecking())
            {
                Console.WriteLine("Стороны треугольника:");
                T1.ShowSides();
                Console.WriteLine("Периметр треугольника: {0}", T1.Perimetr());
                Console.WriteLine("Площадь треугольника: {0}", T1.Area());
            }
            else
                Console.WriteLine("Такого треугольника не существует!");
        }
    }
}
