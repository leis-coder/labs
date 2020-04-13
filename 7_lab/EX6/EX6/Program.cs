using System;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какая прогрессия Вас интересует? \n\tа - арифметическая\n\tг - геометрическая");
            char chose = char.Parse(Console.ReadLine());

            switch (chose)
            {
                case 'a':
                case 'а':
                    Console.Write("Укажите значение первого элемента прогрессии: ");
                    double F1 = double.Parse(Console.ReadLine());
                    Console.Write("Укажите значение разницы: ");
                    double R1 = double.Parse(Console.ReadLine());
                    Console.Write("Укажите значение какого элемента вас интересует: ");
                    int Nomer1 = int.Parse(Console.ReadLine());
                    ArithmeticProgression A = new ArithmeticProgression(F1,R1);
                    Console.WriteLine("{0} элемент прогрессии равен: {1}",Nomer1, A.GetElement(Nomer1));
                    break;
                case 'г':
                    Console.Write("Укажите значение первого элемента прогрессии: ");
                    double F2 = double.Parse(Console.ReadLine());
                    Console.Write("Укажите значение множителя: ");
                    int R2 = int.Parse(Console.ReadLine());
                    Console.Write("Укажите значение какого элемента вас интересует: ");
                    int Nomer2 = int.Parse(Console.ReadLine());
                    GeometricProgression G = new GeometricProgression(F2,R2);
                    Console.WriteLine("{0} элемент прогрессии равен: {1}",Nomer2, G.GetElement(Nomer2));
                    break;
            }
        }
    }
}
