using System;
using static System.Console;

namespace P182_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {

            bool work = true;

            while (work == true)
            {

                Write("반복횟수를 입력하세요 : ");

                int input = Convert.ToInt32(ReadLine());

                if (input == 119)
                {
                    WriteLine("긴급 종료합니다.");
                    work = false;
                }

                else if (input > 0)
                {
                    for (int i = 0; i < input; i++)
                    {
                        for (int q = 0; q < i + 1; q++)
                        {
                            Write("*");
                        }
                        WriteLine("");
                    }

                }
                
                else
                    Write("0보다 작거나 같은 수는 입력할수없습니다.");
            }
           

        }
    }
}
