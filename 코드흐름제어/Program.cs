﻿/*
 * 학습 목표 : 반복문과 제어문
 * 작성일     : 2024-08-24
 * 작성자     : 박종관
 */

/*
 *  복습 겸 학습 개요
 *  네임스페이스 + 클래스와 메소드
 */

/*
 *  범위 지정  
 *  
 *  범위의 시작{ 
 *  
 *  } 범위의 끝
 */

/*
 *  목표 : 게임 시작 메뉴 만들기 (C# 언어로)
 *  게임 시작, 게임 종료
 *  1. 두개의 선택 사항을 구분하여 코드를 제어하는 방법 (조건문) If조건문, switch조건문
 *  2. 시작하자 마자 프로그램이 종료가 되는 것을 방지. 계속해서 프로그램이 실행. -> 무한 반복문 / for반복문, while 반복문
 */

namespace 코드흐름제어
{
    internal class Program
    {
        static void Main(string[] args) // 프로그램을 시작하는 메소드의 시작
        {
            Console.WriteLine("주말 C# 강의 3번째 클래스");
            Console.WriteLine("반복문과 조건문");

            Console.WriteLine("실행할 강의를 선택해주세요(1. : if조건문, 2 : switch 조건문, 3 : for 반복문, 4 : while 반복문, 5 : gamemanager) : ");
            int userInput = int.Parse(Console.ReadLine());

            Console.Write("");

            if(userInput == 1)
            If조건문.Show();           // if문 강의 내용
            else if(userInput ==2)
            switch조건문.Show();       // switch문 강의 내용
            else if (userInput ==3)
            for반복문.Show();                                  // for문 강의 내용
            else if( userInput ==4)
            while반복문.Show();                                  // while문 강의 내용
            else if ( userInput ==5)
            gamemanager.ShowMenu();

                                              // 게임 메인 화면 구성

                // 프로그램을 종료한다.
        }
    }
}
