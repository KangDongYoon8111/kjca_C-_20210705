using System;

namespace p182_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //무한반복, 119가 입력되면 종료

            Console.Write("반복할 횟수를 입력 : ");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);

            if (num <= 0)
                Console.WriteLine("0보다 작거나 같아? 안해");

            bool t = true;

            switch (t)
            {
                case "119":
                    t = false;
                    break;
                    for (var a = 1; a <= num; a++)
                    {
                        for (var b = 1; b <= a; b++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
            }
        }
    }
}
