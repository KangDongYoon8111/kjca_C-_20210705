using System;

namespace Ex6_2
{
    class Program
    {
        static void Main()
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, mean);

            Console.WriteLine("평균 : {0}", mean); //Mean에서 받아온 mean이아니라 처음에 0으로 초기화한 main의 mean이 뿌려졌기 때문        }
        }
        public static void Mean(double a, double b, double c, double d, double e, double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
