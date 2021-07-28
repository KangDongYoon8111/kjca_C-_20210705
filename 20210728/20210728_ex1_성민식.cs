using System;

namespace _20210728_ex1_성민식
{
    class Program
    {
        static double Square(double arg)
        {
            return arg * arg;
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            double arg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
