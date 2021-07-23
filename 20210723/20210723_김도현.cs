using System;

namespace _20210723_김도현
{
    class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
  
            while (state)
            {
                Console.Write("반복 횟수를 입력하세요 : ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 119) { Console.WriteLine("시스템 종료"); state = false; }

                if (a < 0) { Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다."); state = false; }

                if( a > 0 && a != 119) 
                { 
                    for (int i = 0; i < a; i++)
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
    }
}
