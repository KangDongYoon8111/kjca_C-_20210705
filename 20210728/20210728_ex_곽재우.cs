using System;

namespace _20200728_ex3_곽재우.cs
{
    class Program
    {
        public static void Main()
        {


            int a = 3;
            int b = 4;
            int resultA = 0;

            plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB); //오버로드가 필요한 메소드입니다.

            Console.WriteLine("{0} + {1} + {2}", x, y, resultB);
        }

        public static void plus(int a, int b, out int c)
        {
            c = a + b;
        }
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}
