using System;
using System.Globalization;

namespace ConsoleApp3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 1. 아래 4가지 형태의 변수를 선언해주세요.
            // 논리형 :
            // 문자형 :
            // 정수형 :
            // 실수형 :
            bool a1 = true;
            char b1 = 'A';
            int c1 = 1;
            float d1 = 3.14f;

            // 2. 생년월일를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    myYear라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            int myYear = 19830221;
            Console.WriteLine(myYear);

            // 3. 주민등록번호를 숫자로 저장하고자 한다. 이값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    regNo라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            string readLine = "830221-1550000";
            int regNo = Convert.ToInt32(readLine.Substring(0, 6));
            Console.WriteLine(regNo);

            // 4. 다음 문장들의 출력 결과를 적으세요. 오류가 있는 문장의 경우, '오류'라고 적으시오.
            // Console.WriteLine("1" + "2"); // "12" (문자열 끼리 연결)
            // Console.WriteLine(true + ""); // "True" (아마 bool 타입 데이터와 문자열의 합은 "True"인듯)
            // Console.WriteLine('A'+'B'); // 65 + 66 = 131 (아스키 값끼리의 합)
            // Console.WriteLine("U" + "nity"); // "Unity" (문자열 끼리 연결)
            // Console.WriteLine(true + null); "True" (왜 이렇게 되는지는 모르겠음)

            // 5. 다음 중 변수의 이름으로 사용할 수 있는 것은?(모두 고르시오)
            // a. _ystem = 1; (가능)
            // b. channel#5 = 2; (불가 : 특수문자 포함)
            // c. 7eleven = 3; (불가 : 숫자로 시작)
            // d. using = 4; (불가 : C# 예약된 키워드 사용)
            // e. 유니티 = 5; (불가 : 한글명 포함)
            // f. new = 6; (불가 : C# 예약된 키워드 사용)
            // g. $MAX_NUM = 7; (불가 : 특수문자 포함)
            // h. hello_com = 8; (가능)

            int a6 = 100;
            float b6 = 3.14f;
            string c6 = "12345";
            string d6 = "7.16";
            // 6. 위 4개의 변수들을 원하시는 형태로 형변환을 진행해주세요.(아는 부분대로 진행해 주시면 됩니다.)
            Console.WriteLine(a6.ToString());
            Console.WriteLine(b6.ToString());
            Console.WriteLine(Convert.ToInt32(c6));
            Console.WriteLine(Convert.ToDouble(d6));

            // 7. 다음 중 변수를 잘못 초기화한 것은? (모두 고르시고, 이유도 적어주세요)
            // a. char e = ''; (잘못 : 컴파일러 오류남 이유는 모르겠지만 빈문자는 char형 변수에 못넣음)
            // b. char annswer = 'no'; (잘못 : "no"는 문자 두개 이상이 모인 문자열임 annswer는 문자형 변수임)
            // c. float f = 3.14; (잘못 : 3.14는 double 형 자료형이고 f는 float형 변수임)
            // d. int g = 7.16; (잘못 : 7.16은 double 형 자료형이고 g는 int형 변수임)

            // 8. 사용자에게 두 개의 수를 입력 받아 곱헤 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            Console.Write("8. 두 개의 수를 입력하세요 : ");
            int a8 = Convert.ToInt32(Console.ReadLine());
            int b8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"곱 : {a8 * b8}");

            // 9. 사용자에게 두 개의 수를 입력 받아 나눠 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            Console.Write("9. 두 개의 수를 입력하세요 : ");
            int a9 = Convert.ToInt32(Console.ReadLine());
            int b9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("몫 : {0} , 나머지 : {1}", a9 / b9, a9 % b9);

            // 10. 사용자에게 네 개의 수를 입력 받아 합해 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            Console.Write("10. 네 개의 수를 입력하세요 : ");
            int a10 = Convert.ToInt32(Console.ReadLine());
            int b10 = Convert.ToInt32(Console.ReadLine());
            int c10 = Convert.ToInt32(Console.ReadLine());
            int d10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"출력 : {a10}, {b10}, {c10}, {d10}");

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
