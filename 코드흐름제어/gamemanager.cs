using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    static class gamemanager
    {
        public static void GameStart()
        {
            Console.WriteLine("게임이 시작했습니다.");
            while(true)
            {
                int a = int.Parse(Console.ReadLine());
                if(a == 0)
                {
                    Console.WriteLine("게임 실행 중");
                }
                else if (a == 1)
                {
                    Console.WriteLine("메뉴를 보여주세요");
                    ShowMenu();
                }
            }
        }

        public static void LoadOption()
        {
            Console.WriteLine("옵션창 입니다.");
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("옵션 설정 중");
                }
                else if (a == 1)
                {
                    ShowMenu();

                }
            }
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("==========게임 메뉴 출력==========");
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 옵션");
            Console.WriteLine("3. 게임 종료");

            while (true)
            {
                //  유니티에서 게임을 시작해주는 클래스와 메소드가 미리 구현이 되어있습니다.
                Console.WriteLine("입력을 기다리고 있습니다 : ");
                int userInput = int.Parse(Console.ReadLine());

                //  1. if조건문, switch문

                if (userInput == 1)
                {
                    Console.WriteLine("게임 시작");
                    GameStart();
                    break;
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("옵션");
                    LoadOption();
                    break ;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("게임 종료");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                }
            }

        }
    }
}
