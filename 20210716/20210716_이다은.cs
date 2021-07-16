using System;

namespace _20210716_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 아래 4가지 형태의 변수를 선언해주세요.
            // 논리형 : bool d = true;
            // 문자형 : char c = '가';
            // 정수형 : int a = 1;
            // 실수형 : float b = 1.1f;


            // 2. 생년월일를 숫자로 저장하고자 한다. 이 값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    myYear라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            int myYear = 1998;

            // 3. 주민등록번호를 숫자로 저장하고자 한다. 이값을 저장하기 위해서는 어떤 데이터형(data type)을 선택해야 할까?
            //    regNo라는 이름의 변수를 선언하고 자신의 생년월일로 초기화하는 한 줄의 코드를 적으시오.
            long regNo = 980319;

            // 4. 다음 문장들의 출력 결과를 적으세요. 오류가 있는 문장의 경우, '오류'라고 적으시오.
            // Console.WriteLine("1" + "2"); = 12
           // Console.WriteLine(true + "");  = true
            // Console.WriteLine('A'+'B'); = 오류
            // Console.WriteLine("U" + "nity"); = Unity
            // Console.WriteLine(true + null); = true


            // 5. 다음 중 변수의 이름으로 사용할 수 있는 것은?(모두 고르시오)
            // a. _ystem = 1;
            // b. channel#5 = 2;
            // c. 7eleven = 3;
            // d. using = 4;
            // e. 유니티 = 5;
            // f. new = 6;
            // g. $MAX_NUM = 7;
            // h. hello_com = 8;
            // 1 , 3 , 5 . 8

            int a = 100;
            float b = 3.14f;
            string c = "안녕하세요?";
            string d = "반갑습니다.";
            // 6. 위 4개의 변수들을 원하시는 형태로 형변환을 진행해주세요.(아는 부분대로 진행해 주시면 됩니다.)


// 7. 다음 중 변수를 잘못 초기화한 것은? (모두 고르시고, 이유도 적어주세요)
// a. char e = ''; 문자 미입력
// b. char annswer = 'no'; 한글자만
// c. float f = 3.14; f붙이기
// d. int g = 7.16; 정수만


// 8. 사용자에게 두 개의 수를 입력 받아 곱헤 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
/* using System;

namespace p112_ex2
{
class MainApp
{
 public static void Main()
 {
     Console.WriteLine("곱할 숫자를 입력하세요 1.");
     string number1 = Console.ReadLine();

     Console.WriteLine("곱할 숫자를 입력하세요 2.");
     string number2 = Console.ReadLine();

     int n1 = Convert.ToInt32(number1);
     int n2 = Convert.ToInt32(number2);

     Console.WriteLine("결과값 : {0}", n1 * n2);
 }
}
}*/

// 9. 사용자에게 두 개의 수를 입력 받아 나눠 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.

/*using System;

namespace p112_ex2
{
class MainApp
{
public static void Main()
{
Console.WriteLine("나눌 숫자를 입력하세요 1.");
string number1 = Console.ReadLine();

Console.WriteLine("나눌 숫자를 입력하세요 2.");
string number2 = Console.ReadLine();

int n1 = Convert.ToInt32(number1);
int n2 = Convert.ToInt32(number2);

Console.WriteLine("결과값 : {0}", n1 / n2);
}
}
} */
// 10. 사용자에게 네 개의 수를 입력 받아 합해 준 뒤, 출력해주는 프로그램을 자유롭게 작성하세요.
/*using System;

namespace p112_ex2
{
    class MainApp
    {
        public static void Main()
        {
            Console.WriteLine("더할 숫자를 입력하세요 1.");
            string number1 = Console.ReadLine();

            Console.WriteLine("더할 숫자를 입력하세요 2.");
            string number2 = Console.ReadLine();

            Console.WriteLine("더할 숫자를 입력하세요 3.");
            string number3 = Console.ReadLine();

            Console.WriteLine("더할 숫자를 입력하세요 4.");
            string number4 = Console.ReadLine();

            int n1 = Convert.ToInt32(number1);
            int n2 = Convert.ToInt32(number2);
            int n3 = Convert.ToInt32(number3);
            int n4 = Convert.ToInt32(number4);

            Console.WriteLine("결과값 : {0}", n1 + n2 + n3 + n4);
        }
    }
}*/

}
}
}