
using System;

namespace p144_ex1
{
    class p144
    {
        static void Main(string[] args)
        {
            // 1. i++와 ++i의 차이점은 무엇인가요?
            //  답 : 전위증가연산자, 후휘증가연산자. 연산자를 변수 뒤에 사용하면 해당 문장의 실행이 끝난 후에 변수의 값이 변경되고, 변수 앞에 사용하면 변수의 값을 변경한 우에 해당문장이 실행된다.
            //
            // 2. 각 출력문의 값을 적으세요
            //      int i = 1;
            //      Console.WriteLine(i = i + 1);   답 :2
            //      Console.WriteLine(i++);         답 :2
            //      Console.WriteLine(++i);         답 :3
            //      Console.WriteLine(i += 1);      답 :2
            //
            // 3. 다음 코드에서 b는 어떤 값을 가질까요?    답 : ABC
            //      int a = 10;
            //      string b = a == 0 ? "가나다" : "ABC";
        }
    }
}
