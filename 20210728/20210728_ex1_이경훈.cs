using System;

namespace _216_ex1
{
    class Program
    {
        
        static double Square(double arg)
        {
            arg *= arg;
            return arg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
