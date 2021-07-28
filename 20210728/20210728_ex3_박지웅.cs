using System;

namespace _20210728_ex3_박지웅
{
    class Program
    {
        static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2)", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB); //오버로드 필요메소드

            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }
        //이 아래에 더블 형 매개변수를 받을 수 있도록
        //오버로딩한 PULS(메소드를 작성하세요)
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }

    }
}