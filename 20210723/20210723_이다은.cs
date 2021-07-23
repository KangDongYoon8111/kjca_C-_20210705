using System;

namespace P182_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("반복 횟수를 입력하세요 : ");
            string num = Console.ReadLine();
            int num1 = Convert.ToInt32(num);

            if (num1 < 0)
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");

            bool stop = true;

            while(stop)
            {
             for(int a = 5; a < 0; a++)
                {
                    for (int b = 0; b < a; b++)

                        Console.WriteLine("*");
                }
                Console.WriteLine("");
                switch (num1)
                {
                    
                }

               
               
                
            }
        }
    }
}
