using System;

namespace _20210716_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 아래 4가지 형태의 변수를 선언해주세요.
            // 논리형 :
            // 문자형 :
            // 정수형 :
            // 실수형 :
            bool a;
            string b;
            int c;
            double d;



            // 2. 생년월일를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    myYear라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            int myYear = 960702;

            // 3. 주민등록번호를 숫자로 저장하고자 한다. 이값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    regNo라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            int regNo = 960702;

            // 4. 다음 문장들의 출력 결과를 적으세요. 오류가 있는 문장의 경우, '오류'라고 적으시오.
            // Console.WriteLine("1" + "2"); 12(문자열) 
            // Console.WriteLine(true + ""); true
            // Console.WriteLine('A'+'B'); 데이터값
            // Console.WriteLine("U" + "nity"); Unity
            // Console.WriteLine(true + null); true ??


            // 5. 다음 중 변수의 이름으로 사용할 수 있는 것은?(모두 고르시오)
            // a. _ystem = 1; ㅇ
            // b. channel#5 = 2; x(특수문자)
            // c. 7eleven = 3; x(숫자시작)
            // d. using = 4; x(키워드)
            // e. 유니티 = 5; x(한글)
            // f. new = 6; x(키워드)
            // g. $MAX_NUM = 7; x(특수문자)
            // h. hello_com = 8; ㅇ


            int a1 = 100;
            float b2 = 3.14f;
            string c3 = "12345";
            string d4 = "7.16";

            // 6. 위 4개의 변수들을 원하시는 형태로 형변환을 진행해주세요.(아는 부분대로 진행해 주시면 됩니다.)
            Console.WriteLine(a1.ToString());
            Console.WriteLine(b2.ToString());
            Console.WriteLine(Convert.ToInt32(a1));

            // 7. 다음 중 변수를 잘못 초기화한 것은? (모두 고르시고, 이유도 적어주세요)
            // a. char e = ''; 안됨
            // b. char annswer = 'no'; 안됨
            // c. float f = 3.14; 안됨 3.14f가능
            // d. int g = 7.16; int인데 정수가아님


            // 8. 사용자에게 두 개의 수를 입력 받아 곱헤 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            Console.WriteLine("첫번째 수를 입력하시오: ");
            string f8 = Console.ReadLine();
            Console.WriteLine("두번째 수를 입력하시오: ");
            string f9 = Console.ReadLine();

            int a8 = Convert.ToInt32(f8);
            int b8 = Convert.ToInt32(f9);
            int c8;
            c8 = a8 * b8;
            Console.WriteLine("곱 : {0} ", c8);


            // 9. 사용자에게 두 개의 수를 입력 받아 나눠 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            Console.WriteLine("첫번째 수를 입력하시오: ");
            string g8 = Console.ReadLine();
            Console.WriteLine("두번째 수를 입력하시오: ");
            string g9 = Console.ReadLine();

            int a9 = Convert.ToInt32(g8);
            int b9 = Convert.ToInt32(g9);
            int c9;
            c9 = a9 / b9;
            double d9;
            d9 = a9 % b9;
            Console.WriteLine("몫 : {0} ", c9);
            Console.WriteLine("나머지 : {0} ", d9);

            // 10. 사용자에게 네 개의 수를 입력 받아 합해 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            Console.WriteLine("첫번째 수를 입력하시오: ");
            string g10 = Console.ReadLine();
            Console.WriteLine("두번째 수를 입력하시오: ");
            string g11 = Console.ReadLine();
            Console.WriteLine("세번째 수를 입력하시오: ");
            string g12 = Console.ReadLine();
            Console.WriteLine("네번째 수를 입력하시오: ");
            string g13 = Console.ReadLine();

            int a10 = Convert.ToInt32(g10);
            int b10 = Convert.ToInt32(g11);
            int c10 = Convert.ToInt32(g12);
            int d10 = Convert.ToInt32(g13);


            int e10;
            e10 = a10 + b10 + c10 + d10;
            Console.WriteLine("값은 : {0}", e10);
        }
    }
}