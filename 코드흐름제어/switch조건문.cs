using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    enum UESRINPUT { GAMESTART = 1, GAMEEND, OPTION   }
    //enum : 열거형.
    //  숫자 1이 무조건 A를 표현할거야. 약속.


    internal static class switch조건문
    {
        static UESRINPUT userEnumInput;
        public static void Show()
        {
            Console.WriteLine("switch 조건문 강의");

            // if

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput) // switch case를 판별할 변수
            {
                case 1:
                    Console.WriteLine("1번 게임시작");
                    break;
                case 2:
                    Console.WriteLine("2번 게임종료");
                    break;
                case 3:
                    Console.WriteLine("3번 옵션");
                    break;
                 default:
                    Console.WriteLine("잘못 입력했습니다. 다시 입력해주세요.");
                    break;
            }

            //  if(userinput ==1)




        }
    }
}
