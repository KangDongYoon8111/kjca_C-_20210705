using System;

namespace _20210728_ex1_김도현
{
    class MainApp
    {
        static double Square(double arg)
        {
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
