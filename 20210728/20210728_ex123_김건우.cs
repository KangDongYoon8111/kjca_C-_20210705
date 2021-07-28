using System;
using System.Collections;

namespace ConsoleApp3
{
    class MainApp
    {
        static void Ex1()
        {
            //string input = Console.ReadLine();
            //int length = 0;
            //int.TryParse(input, out length);

            int length = 0;
            Console.WriteLine(Square(length));

            double Square(double arg)
            {
                return arg * arg;
            }
        }

        static void Ex2()
        {
            double mean = 0;
            Mean(1, 2, 3, 4, 5);
            Console.WriteLine(mean);

            void Mean(params double[] args)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    mean += args[i];
                }
            }
        }

        static void Ex2_2()
        {
            double mean = 0;
            Mean(6, 7, 8, 9, 10, ref mean);
            Console.WriteLine(mean);

            void Mean(double a, double b, double c, double d, double e, ref double mean)
            {
                mean = a + b + c + d + e;
            }
        }

        static void Ex3()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;
            Plus(a, b, out resultA);
            Console.WriteLine(resultA);

            double d = 2.4;
            double e = 3.1;
            double resultB = 0;
            Plus(d, e, out resultB);
            Console.WriteLine(resultB);
        }
        static void Plus(int a, int b, out int result)
        {
            result = a + b;
        }
        static void Plus(double a, double b, out double result)
        {
            result = a + b;
        }


        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex2_2();
            Ex3();
        }
    }
}
