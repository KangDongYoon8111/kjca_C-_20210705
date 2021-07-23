using System;
using static System.Console;

namespace _20210723_osm
{
    class Program
    {
        static void Main(string[] args)
        {

            bool a = true;

            while (a)
            {
                Write("반복 횟수를 입력하세요");
                int b = Int32.Parse(ReadLine());

                if (b > 0)
                {
                    for (int i = 0; i < b; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Write("*");
                        }
                        WriteLine();
                    }
                }
                else
                    WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                if (b == 119)
                {
                    a = false;
                }
            }
        }
    }
} 
