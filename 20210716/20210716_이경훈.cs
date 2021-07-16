using System;

namespace Test20210716
{
    class Program
    {
        static void Main(string[] args)
        {
        // 1. 아래 4가지 형태의 변수를 선언해주세요.
        // 논리형 :
        bool idiota = false;
        // 문자형 :
        string name = "Huni";
        // 정수형 :
        int a = 123;
        // 실수형 :
        float b = 123.456f;


            // 2. 생년월일를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
        int year = 1;
        //    myYear라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
        int myYear = 961110;

            // 3. 주민등록번호를 숫자로 저장하고자 한다. 이값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    regNo라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            ulong regNo = 9611101234567;


            // 4. 다음 문장들의 출력 결과를 적으세요. 오류가 있는 문장의 경우, '오류'라고 적으시오.
            // Console.WriteLine("1" + "2");
            // Console.WriteLine(true + "");
            // Console.WriteLine('A'+'B');
            // Console.WriteLine("U" + "nity");
            // Console.WriteLine(true + null);


            // 5. 다음 중 변수의 이름으로 사용할 수 있는 것은?(모두 고르시오)
            // a. _ystem = 1;
            // b. channel#5 = 2;
            // c. 7eleven = 3;
            // d. using = 4;
            // e. 유니티 = 5;
            // f. new = 6;
            // g. $MAX_NUM = 7;
            // h. hello_com = 8;

        // a, v, d ,e, f, h
        


            int aa = 100;
            float bb = 3.14f;
            string c = "12345";
            string d = "7.16";
        // 6. 위 4개의 변수들을 원하시는 형태로 형변환을 진행해주세요.(아는 부분대로 진행해 주시면 됩니다.)

        Convert.ToInt32(bb);
        Convert.ToInt32(c);
        Convert.ToDouble(bb);
        Convert.ToDouble(d);




        // 7. 다음 중 변수를 잘못 초기화한 것은? (모두 고르시고, 이유도 적어주세요)
        // a. char e = '';
        // b. char annswer = 'no';

        // 문자열은 큰 따옴표가 필요함
        // c. float f = 3.14;

        // float은 마지막에 f를 붙여야함
        // d. int g = 7.16;

        //int는 정수만 표시가능


        // 8. 사용자에게 두 개의 수를 입력 받아 곱헤 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.


        Console.WriteLine("\n\n곱셈 계산기 입니다?\n\n");

        Console.WriteLine("첫번째 숫자를 적어주세요?");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("두번째 숫자를 적어주세요?");
        int b1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"정답은 {a1*b1} 입니다");



        // 9. 사용자에게 두 개의 수를 입력 받아 나눠 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.

        Console.WriteLine("\n\n\t나눗셈 계산기 입니다?\n\n");

        Console.WriteLine("첫번째 숫자를 적어주세요?");
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("두번째 숫자를 적어주세요?");
        int b2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"정답은 {a2 / b2} 입니다");


        // 10. 사용자에게 네 개의 수를 입력 받아 합해 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.

        Console.WriteLine("\n\n\t\t덧셈 계산기 입니다?\n\n");

        Console.WriteLine("첫번째 숫자를 적어주세요?");
        int a3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("두번째 숫자를 적어주세요?");
        int b3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("세번째 숫자를 적어주세요?");
        int c3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("네번째 숫자를 적어주세요?");
        int d3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"정답은 {a3 + b3 + c3 + d3} 입니다");
    }
}
}