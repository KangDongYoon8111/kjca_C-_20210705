using System;

namespace p144_ex1
{
    class p144
    {
        static void Main(string[] args)
        {
            // 1. i++와 ++i의 차이점은 무엇인가요?
            //  답 : 예를 들어서 i값이 10이라면  i++은 10을 출력후 저장된값에1값 증가 , ++i는 11을 출력
            //
            // 2. 각 출력문의 값을 적으세요
            //      int i = 1;
            //      Console.WriteLine(i = i + 1);   답 : 2
            //      Console.WriteLine(i++);         답 : 2
            //      Console.WriteLine(++i);         답 : 4
            //      Console.WriteLine(i += 1);      답 : 5
            //
            // 3. 다음 코드에서 b는 어떤 값을 가질까요?    답 :  "ABC"
            //      int a = 10;
            //      string b = a == 0 ? "가나다" : "ABC";

            int a = 10;
            string b = a == 0 ? "가나다" : "ABC";
            Console.WriteLine(b);


            int i = 1;
            Console.WriteLine(i = i + 1);   // 답 : 2
            Console.WriteLine(i++);         // 답 : 2
            Console.WriteLine(++i);         // 답 : 4
            Console.WriteLine(i += 1);      // 답 : 5


            int z = 1;
            Console.WriteLine(++z);// 출력값 :2
            int zz = 1;
            Console.WriteLine(zz++);//출력값 :1

        }
    }
}