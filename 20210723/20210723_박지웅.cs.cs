using System;

namespace p169_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요 : ");
             String input = Console.ReadLine();
            int number = Convert.ToInt32(input);


                if (number <= 0) Console.WriteLine("O보다 작거나 같은 수는 입력할 수 없습니다.");

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

//책에 나온 것까지만 했습니다.