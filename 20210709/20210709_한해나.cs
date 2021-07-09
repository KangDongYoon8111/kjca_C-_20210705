using System;//시스템이라는 네임스페에스를 사용하겠다
using static System.Console;//콘솔의 멤버들을 이름을 명시하지 않고 사용하겠다 선언

namespace ConsoleApp1//네임스페이스 이름
{
    class Program//클래스 이름
    {
        static void Main(string[] args)//진입점. 메소드 시작
        {
            if (args.Length == 0) //조건문, 매개변수와 같을 경우
            {
                Console.WriteLine("사용법 : Hello.exe <이름>"); //"" 안에 있는 내용을 출력하겠다. 사용법 표시
                return;//메소드 종료
            }

            WriteLine("Hello, {0}!", args[0]);//"헬로우, {입력한 내용}!" 출력한다
        }
    }
}
