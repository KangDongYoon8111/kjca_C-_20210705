using System;

namespace p261

{
    class MainApp
    {
        static double Square(double arg)
        {
            return arg ** 2;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과: {0}", Square(arg));
        }
    }
}