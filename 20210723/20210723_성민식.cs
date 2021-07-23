using System;
using static System.Console;

namespace p182_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool q = true;
            while (q)
            {
                Write("반복횟수를 입력하세요.");
                int a = Convert.ToInt32(ReadLine());

                if (a <= 0)
                    WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                else if (a == 119)
                    q = false;
                else
                {
                    for (int b = 0; b <= a; b++)
                    {
                        for (int c = 0; c < b; c++)
                        {
                            Write("*");
                        }
                        WriteLine();
                    }
                }
            }
        }
    }
}
