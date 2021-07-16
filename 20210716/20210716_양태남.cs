using System;

namespace _20210716_양태남
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 아래 4가지 형태의 변수를 선언해주세요.
            // 논리형 :bool
            // 문자형 :string
            // 정수형 :int
            // 실수형 :float


            // 2. 생년월일를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까? int
            //    myYear라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            int myYear = 20041130;

            // 3. 주민등록번호를 숫자로 저장하고자 한다. 이값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까? int
            //    regNo라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            int regNo = 041130;

            // 4. 다음 문장들의 출력 결과를 적으세요. 오류가 있는 문장의 경우, '오류'라고 적으시오.
            // Console.WriteLine("1" + "2"); 12
            // Console.WriteLine(true + ""); 오류
            // Console.WriteLine('A'+'B'); AB
            // Console.WriteLine("U" + "nity"); Unity
            // Console.WriteLine(true + null); 오류


            // 5. 다음 중 변수의 이름으로 사용할 수 있는 것은?(모두 고르시오)   b,f
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
            string c = "12345";    char c = '1', char e = '2', char f = '3', char g = '4', char h = '5'
            string d = "7.16";    float d = 7.16f;
            // 6. 위 4개의 변수들을 원하시는 형태로 형변환을 진행해주세요.(아는 부분대로 진행해 주시면 됩니다.)


            // 7. 다음 중 변수를 잘못 초기화한 것은? (모두 고르시고, 이유도 적어주세요)
            // a. char e = '';  ''안에 문자가 들어가야한다
            // b. char annswer = 'no'; char은 한글자씩 해야함
            // c. float f = 3.14;   3,14뒤에 f가 들어가야함
            // d. int g = 7.16;   int는 정수, 소수X


            // 8. 사용자에게 두 개의 수를 입력 받아 곱헤 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            Console.WriteLine("원하시는 숫자를 입력하세요.");
            string Number1 = Console.ReadLine();

            Console.WriteLine("원하시는 숫자를 한번더 입력하세요.");
            string Number2 = Console.ReadLine();

            int numNumber1 = Convert.ToInt32(Number1);
            int numNumber2 = Convert.ToInt32(Number2);
            int multiplication = numNumber1 * numNumber2;


                Console.WriteLine("둘을 곱한 값은 : {0}", multiplication);


            // 9. 사용자에게 두 개의 수를 입력 받아 나눠 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            
            Console.WriteLine("원하시는 숫자를 입력하세요.");
            string Number3 = Console.ReadLine();

            Console.WriteLine("원하시는 숫자를 한번더 입력하세요.");
            string Number4 = Console.ReadLine();

            int numNumber3 = Convert.ToInt32(Number3);
            int numNumber4 = Convert.ToInt32(Number4);
            int division = numNumber3 / numNumber4;


            Console.WriteLine("둘을 나눈 값은 : {0}", division);

            // 10. 사용자에게 네 개의 수를 입력 받아 합해 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.

            Console.WriteLine("원하시는 숫자 4개를 입력하세요.");
            string Number5 = Console.ReadLine();
            string Number6 = Console.ReadLine();
            string Number7 = Console.ReadLine();
            string Number8 = Console.ReadLine();
            
            int numNumber5 = Convert.ToInt32(Number5);
            int numNumber6 = Convert.ToInt32(Number6);
            int numNumber7 = Convert.ToInt32(Number7);
            int numNumber8 = Convert.ToInt32(Number8);
            int plus = numNumber5 + numNumber6 + numNumber7 +numNumber8;

            Console.WriteLine("4개의 숫자를 더한 값은 : {0}", plus);
        }
    }
}