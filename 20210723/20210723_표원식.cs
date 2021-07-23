using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210723
{
    class Program
    {
        static void Main(string[] args)
        {

            bool a = true;//무한동작장치
            while (a)
            {
                Console.WriteLine("반복 횟수를 입력하세요 :");
                int input = Convert.ToInt32(Console.ReadLine());//값 입력 받음
                if (input <= 0  )//받는값이 0이하 일경우
                {
                    Console.WriteLine("0보다 작거나 같은 수는 입력 할 수 없습니다.");
                    a = false;

                }else if(input == 119)//119 입력받았을 경우
                {
                    Console.WriteLine("119입력시 종료됩니다.");
                    a = false;
                }
                else//입력받은 수 만큼 * 표시
                {
                    for(int i=0;i < input; i++)
                        for(int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                    Console.WriteLine();
                }

            }

        }
    }
}
