using System;
using static System.Console;

namespace _20210723_맹라현
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while (true) { 
                Write("반복횟수를 입력하세요 : ");
                int input = Convert.ToInt32(ReadLine());

                if (input == 119) 
                { 
                    WriteLine("신고해드릴까요?");
                    return;
                }

                    
                if (input > 0)
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
                    WriteLine("0보다 작거나 같은 수는 입력할수없습니다.");
            }
        }
    }

}
