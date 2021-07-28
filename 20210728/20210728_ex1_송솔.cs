using System;

namespace p216_ex1
{
    class Program
    {
        static double Square(double arg)
        {
            double i = arg * arg;
            return i;
        }
        static void Main(string[] args)
        {
            Console.Write("수를 입력하시오 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);
            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
