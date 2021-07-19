using System;

namespace ConsoleApp3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 1. i++와 ++i의 차이점은 무엇인가요?
            //  답 : 선 연산 후 증가 , 선 증가 후 연산의 차이 (연산자 우선순위)
            //
            // 2. 각 출력문의 값을 적으세요
            //      int i = 1;
            //      Console.WriteLine(i = i + 1);   답 : 2
            //      Console.WriteLine(i++);         답 : 2 (선 연산 후 증가)
            //      Console.WriteLine(++i);         답 : 4 (선 증가 후 연산)
            //      Console.WriteLine(i += 1);      답 : 5
            //
            // 3. 다음 코드에서 b는 어떤 값을 가질까요?    답 : "ABC" (삼항 조건 연산자 사용법)
            //      int a = 10;
            //      string b = a == 0 ? "가나다" : "ABC";
        }
    }
}
