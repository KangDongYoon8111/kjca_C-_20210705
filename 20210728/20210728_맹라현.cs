using System;

namespace Ex6_3
{
    class Program
    {
        static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plusi(a, b, out resultA);

            Console.WriteLine("{0}+{1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plusd(x, y, out resultB);

            Console.WriteLine("{0}+{1} = {2}", x, y, resultB);

        }

        public static void Plusi(int a, int b, out int c)
        {
             c =  a + b;
        }

        public static void Plusd(double i, double j, out double z)
        {
            z = i + j;
        }
    }
}
