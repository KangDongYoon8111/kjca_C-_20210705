using System;

namespace _20210716_해나
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. 아래 4가지 형태의 변수를 선언해주세요.
            // 논리형 : bool a = true;
            // 문자형 : string a = "name";
            // 정수형 : int a = 100;
            // 소수형 : float a = 3.1;


            // 2. 생년월일를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까? 숫자 형식
            //    myYear라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오. int myYear = 991224;


            // 3. 주민등록번호를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까? 문자열 형식
            //    regNo라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오. object regNo = "991224";
            


            // 4. 다음 문장들의 출력 결과를 적으세요. 오류가 있는 문장의 경우, '오류'라고 적으시오.
            // Console.WriteLine("1" + "2"); 12
            // Console.WriteLine(true + ""); true
            // Console.WriteLine('A'+'B'); AB
            // Console.WriteLine("U" + "nity"); Unity
            // Console.WriteLine(true + null); 오류


            // 5. 다음 중 변수의 이름으로 사용할 수 있는 것은?(모두 고르시오) a, c, e, f, g, h
            // a. _ystem = 1;
            // b. channel#5 = 2;
            // c. 7eleven = 3;
            // d. using = 4;
            // e. 유니티 = 5;
            // f. new = 6;
            // g. $MAX_NUM = 7;
            // h. hello_com = 8;


            int a = 100;
            string A = a.ToString();

            float b = 3.14f;
            int B = (int)b;

            string c = "12345";
            int C = Convert.ToInt32(c);

            string d = "7.16";
            float D = float.Parse(d);

            // 6. 위 4개의 변수들을 원하시는 형태로 형변환을 진행해주세요.(아는 부분대로 진행해 주시면 됩니다.)



            // 7. 다음 중 변수를 잘못 초기화한 것은? (모두 고르시고, 이유도 적어주세요) 
            // a. char e = '';
            // b. char annswer = 'no'; char는 한글자만 가능함
            // c. float f = 3.14; 초기화 값 숫자 뒤에 f를 입력하지 않음
            // d. int g = 7.16; int는 정수 형식으로 값이 부동소수점 형식이라 안됨


            // 8. 사용자에게 두 개의 수를 입력 받아 곱헤 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            int result = 3 * 1;
            Console.WriteLine(result);


            // 9. 사용자에게 두 개의 수를 입력 받아 나눠 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            int num = 15 / 3;
            Console.WriteLine(num);

            // 10. 사용자에게 네 개의 수를 입력 받아 합해 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
            int aa = 20 + 10 + 40 + 30;
            Console.WriteLine(aa);

            }
        }
    }

