using System;

namespace p182_ex4
{
    class Program
    {
        //계속적으로 반복되게 만들어주세요.
        //반복횟수에 119가 입력되면 프로그램이 종료되게 만들어주새요.
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("반복 횟수를 입력하세요. :");
                string input  = Console.ReadLine();
                int number = Convert.ToInt32(input);
                

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
