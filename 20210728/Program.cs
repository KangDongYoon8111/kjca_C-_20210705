using System;

namespace _21210728_ex1_이은우
{
    class Program
    {
        static double Square(double arg)
        {
            return arg * arg;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("수를입력하시오: ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
