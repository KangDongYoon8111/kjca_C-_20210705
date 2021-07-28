using System;

namespace p216_ex1
{
    class Program
    {
        static double Square(double a)
        {
            return a * a;
        }
        
        static void Main(string[] args)
        {

            Console.Write("수를 입력하세요. : ");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("결과 : {0}", Square(input));

        }   
    }
}