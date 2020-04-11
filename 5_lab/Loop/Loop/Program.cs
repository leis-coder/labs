using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray;
            int n = int.Parse(Console.ReadLine());
            MyArray = new int[n];
            for (int i = 0; i < MyArray.Length; ++i) 
            {
                Console.Write("a[{0}]=", i); 
                MyArray[i] = int.Parse(Console.ReadLine()); 
            }
            foreach (int x in MyArray) Console.Write("{0} ", x);

            //int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };

            //for (int i=0; i<10; i++)
            //{
            //    if (myArray[i] % 2 == 0)
            //        myArray[i] = 0;

            //    Console.Write("{0}  ", myArray[i]);
            // }



            //    Console.Write("n = ");
            //    int n = int.Parse(Console.ReadLine());

            //    // while:
            //    Console.Write("\nwhile: \t\t");
            //    int i = 1;
            //    while (i <= n)
            //    {
            //        Console.Write(" " + i);
            //        i += 2;
            //    }

            //    // do while:
            //    Console.Write("\ndo while: \t");
            //    i = 1;
            //    do
            //    {
            //        Console.Write(" " + i);
            //        i += 2;
            //    }
            //    while (i <= n);

            //    // for: 
            //    Console.Write("\nFor: \t\t");
            //    for (i = 1; i <= n; i += 2)
            //    {
            //        Console.Write(" " + i);
            //    }



            //    double x, x1, x2, y;
            //    Console.Write("Введите границы интервала. х1 = ");
            //    x1 = double.Parse(Console.ReadLine());
            //    Console.Write("\nх2 = ");
            //    x2 = double.Parse(Console.ReadLine());

            //    x = x1;
            //    do
            //    {
            //        y = Math.Sin(x);
            //        Console.WriteLine("Sin({0}) = {1}", x, y);
            //        x = x + 0.01;
            //    }
            //    while (x <= x2);



            //    int a, b, temp;

            //    Console.Write("Введите значение первого числа. а = ");
            //    a = int.Parse(Console.ReadLine());
            //    Console.Write("Введите значение второго числа. b = ");
            //    b = int.Parse(Console.ReadLine());

            //    temp = a;

            //    while (temp != b)
            //    {
            //        a = temp;
            //        if (a < b)
            //        {
            //            temp = a;
            //            a = b;
            //            b = temp;
            //        }
            //        temp = a - b;
            //    }

            //    Console.WriteLine("Наибольший общий делитель, найденный с помощью цикла с предусловием: {0}", temp);
        }
    }
}