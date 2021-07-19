using System;

namespace p144_ex1
{
    class p144
    {
        static void Main(string[] args)
        {
            // 1. i++와 ++i의 차이점은 무엇인가요?
            //  답 : i++는 후위증가 연산자입니다 => 해당 문장의 실행이 끝난 후에 변수 값이 연산처리됩니다.
            //       ++i는 전위증가 연산자입니다 => 변수 값이 연산된 후에 문장이 실행됩니다.
            //
            // 2. 각 출력문의 값을 적으세요
            //      int i = 1;
            //      Console.WriteLine(i = i + 1);   답 : 2
            //      Console.WriteLine(i++);         답 : 2
            //      Console.WriteLine(++i);         답 : 4
            //      Console.WriteLine(i += 1);      답 : 5
            //
            // 3. 다음 코드에서 b는 어떤 값을 가질까요?    답 : ABC
            //      int a = 10;
            //      string b = a == 0 ? "가나다" : "ABC";
        }
    }
}