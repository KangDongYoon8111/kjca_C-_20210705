using System;

namespace p182_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1;
            int no1=5;
            string comments1 = "반복횟수를 입력하세요 : (끝내시려면 119)";
            string comments2 = "0보다 작거나 같은 수는 입력할 수 없습니다.";
            string outPut1 = "*";


            while(no1 != 119)
            {
                Console.Write(comments1);
                st1 = Console.ReadLine();//반복횟수 입력받음
                no1 = Convert.ToInt32(st1);
                if (no1 == 119) break;
                if (no1 < 0)
                {
                    Console.WriteLine(comments2);
                    continue;
                }
                for (int i = 0; i < no1 + 1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(outPut1);
                    }
                    Console.WriteLine(" ");
                }
            }




        }
    }
}
