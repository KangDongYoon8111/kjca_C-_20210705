using System;

namespace _20210728_ex2_권소진
{
    class Program
    {
        public static void Main()
        {
            double mean = 0;

            Mean (1, 2, 3, 4, 5, ref mean);
            //값에 의한 변수가 아닌 참조에 의한 변수

            Console.WriteLine("평균: {0}", mean);
        }

        public static void Mean(
            double a, double b, double c,
            double d, double e, ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
