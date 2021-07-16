using System;

namespace _20210716_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 아래 4가지 형태의 변수를 선언해주세요.
            // 논리형 : bool
            // 문자형 : char
            // 정수형 : int
            // 실수형 : float


            // 2. 생년월일를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    myYear라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.

            string myYear = "1996년8월6일";
            Console.WriteLine($"내 생일은 {myYear}이야");


            // 3. 주민등록번호를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    regNo라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.

            int regNo = 960806;
            Console.WriteLine($"내 주민등록번호는 {regNo}야");

            // 4. 다음 문장들의 출력 결과를 적으세요. 오류가 있는 문장의 경우, '오류'라고 적으시오.
            // Console.WriteLine("1" + "2"); => 12  
            // Console.WriteLine(true + ""); => true 
            // Console.WriteLine('A'+'B'); => AB (131)
            // Console.WriteLine("U" + "nity"); => Unity
            // Console.WriteLine(true + null); => ??


            // 5. 다음 중 변수의 이름으로 사용할 수 있는 것은?(모두 고르시오) 모두 X
            // a. _ystem = 1; 
            // b. channel#5 = 2; 
            // c. 7eleven = 3; 
            // d. using = 4;
            // e. 유니티 = 5;
            // f. new = 6; 
            // g. $MAX_NUM = 7;
            // h. hello_com = 8;


            int a = 100;
            float b = 3.14f;
            string c = "12345";
            string d = "7.16";
            // 6. 위 4개의 변수들을 원하시는 형태로 형변환을 진행해주세요.(아는 부분대로 진행해 주시면 됩니다.)
            double be = 3.14;


            // 7. 다음 중 변수를 잘못 초기화한 것은? (모두 고르시고, 이유도 적어주세요)
            // a. char e = ''; => 값을 입력하지 않음
            // b. char annswer = 'no'; => 단일 문자가 아님
            // c. float f = 3.14; => 더블써야됨
            // d. int g = 7.16; => 정수형이 아님


            // 8. 사용자에게 두 개의 수를 입력 받아 곱헤 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.

            Console.Write("첫번째 숫자를 입력해주세요 : ");
            int ex1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("두번째 숫자를 입력해주세요 : ");
            int ex2 = Convert.ToInt32(Console.ReadLine());

            int re1 = ex1 * ex2;

            Console.WriteLine(re1);

            // 9. 사용자에게 두 개의 수를 입력 받아 나눠 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.

            Console.Write("첫번째 숫자를 입력해주세요 : ");
            int ex3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("두번째 숫자를 입력해주세요 : ");
            int ex4 = Convert.ToInt32(Console.ReadLine());

            int re2 = ex3 / ex4;

            Console.WriteLine(re2);

            // 10. 사용자에게 네 개의 수를 입력 받아 합해 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.

            Console.Write("첫번째 숫자를 입력해주세요 : ");
            int ex5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("두번째 숫자를 입력해주세요 : ");
            int ex6 = Convert.ToInt32(Console.ReadLine());

            int re3 = ex5 + ex6;

            Console.WriteLine(re3);
        }
    }
}