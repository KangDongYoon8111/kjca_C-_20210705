using System;

namespace _20210728_ex2_박지웅
{
    class Program
    {
        static void Main()
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, out mean ); //out이 필요

            Console.WriteLine("평균 : {0}", mean);
        }
        public static void Mean(
            double a, double b, double c,
            double d, double e, out double mean) //out이 필요
        {
            mean = (a + b + c + d + e) / 5;
        }    
    }
}
