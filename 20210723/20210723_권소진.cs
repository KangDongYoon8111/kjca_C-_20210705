using System;

namespace _20210723_권소진
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("반복 횟수를 입력하세요.:");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input <= 0)
                {
                    Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                }

                else if (input == 119)
                    break;

                else
                {
                    for(int a = input; a>0; a--)
                    {
                        for (int b = 0; b <a; b++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
