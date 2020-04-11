using System;

namespace Ex3
{
    class Program
    {
        public static int Summ(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }

        public static float Average(int[] a)
        {
            return Summ(a) / a.Length;
        }

        public static int Positive(int[] a)
        {
            int P = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] > 0)
                    P += a[i];
            return P;
        }

        public static int Even(int[] a)
        {
            int E = 0;
            for (int i = 0; i < a.Length; i += 2)
                E += a[i];
            return E;
        }

        public static int Maximum(int[]a)
        {
            int m = a[0];
            int mi = 0;
            for (int i=1; i<a.Length; i++)
            {
                if (m<a[i])
                {
                    m = a[i];
                    mi = i;
                }
            }
            return mi;
        }

        public static int Minimum(int[] a)
        {
            int m = a[0];
            int mi = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (m > a[i])
                {
                    m = a[i];
                    mi = i;
                }
            }
            return mi;
        }

        public static int Proisvedenie(int[]a)
        {
            int p = 1;
            int c, b;

            if (Minimum(a) < Maximum(a))
            {
                c = Maximum(a);
                b = Minimum(a);
            }
            else
            {
                c = Maximum(a);
                b = Minimum(a);
            }
            for (int i =c+1; i<b; i++)
            {
                p = p * a[i];
            }
            return p;
        }
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Summ is: {0}", Summ(a));
            Console.WriteLine("Average result is: {0}", Average(a));
            Console.WriteLine("Summ of positive elements is: {0}", Positive(a));
            Console.WriteLine("Summ of elements with even index is: {0}", Even(a));

            Console.WriteLine("Maximum is: {0}", a[Maximum(a)]);
            Console.WriteLine("Minimum is: {0}", a[Minimum(a)]);
            Console.WriteLine(Proisvedenie(a));
        }
    }
}
