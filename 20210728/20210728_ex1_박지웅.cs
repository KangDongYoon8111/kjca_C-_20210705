using System;

namespace _20210728_ex1_박지웅
{
    class Program
    {
        static double Square(double arg)
        {
            //이 메소드를 구현하세요

            return arg * arg;
        }



        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
