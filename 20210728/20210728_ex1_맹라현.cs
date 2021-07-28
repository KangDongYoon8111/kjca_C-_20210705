using System;
using static System.Console;

namespace LocalFunction
{
    class Program
    {
        static double Square(double i)
        {
            return i*i;

        }
        static void Main(string[] args)
        {
            Write("수를 입력하세요 : ");
            double i = Convert.ToDouble(ReadLine());

            WriteLine("결과 : {0}",Square(i));
        }
    }
}
