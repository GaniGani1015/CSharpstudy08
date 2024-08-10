// 주석 : 컴퓨터는 알아볼 수 없지만 사람만 알아볼 수 있게 표시하는 기능
// 1. // 해당 줄은 주석처리된다.(컴퓨터는 알아볼 수 없게 된다.)
// 2. /* */ : /* ~ */ 모두 주석 처리한다.

/*
 * 학습 목표 : CSharp 언어로 첫 프로그래밍 작성하기. 변수에 대한 이해
 * 작성일    : 2024-08-10
 * 작성자    : 박종관
 */


/*
 * 프로그래밍 + 언어 
 * 프로그래밍 : 컴퓨터로 프로그램을 작동시키는 작업(사람이 함)
 * 언어       :두 객체 사이의 대화를 위한 도구
 * 프로그래밍 언어 : 컴퓨터와 사람이 대화를 하기 위해 필요한 언어다.
 * 
 * 사람은 기계가 하는 말을 알아들을 수 있습니까? -> X
 * 기계가 사람이 하는 말을 알아들을 수 있습니까? -> X
 * 번역기, 통역사 -> 컴파일러 : 사람과 컴퓨터 사이에 번역(통역)을 해주는 기계
 * 언어마다 번역기가 다르다.
 *
 */

/*
 * 컴퓨터가 사람이 사용하는 언어를 표현하는 방법을 모방하려면
 * 정수는 정수 방식으로 표현한다.
 * 키워드 -> 이미 의미가 정해져 있는 단어. 파란색으로 표시되어 있는 단어.
 * 흰색 : 어떤 것(데이터 타입의 이름)
 * 밝은 노란색 : 함수
 * 
 *  정수는 정수 방식으로 표현한다.
 *  실수는 실수 방식으로 표현한다.
 *  문자는 문자 방식으로 표현한다.
 *  
 * 정수 방식으로 사용하는 키워드 : int
 * 실수 방식으로 사용하는 키워드 : float
 * 단어 방식으로 사용하는 키워드 : char
 * 문자열 방식으로 사용하는 키워드 : string
 */

/*
 * 
 * 
 */
using System.Threading.Channels;

namespace CSharpstudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하세요~");

            Console.WriteLine("컴퓨터에게 정수, 실수, 문자, 문자열을 입력시켜 본다.");

            // 변수 : 변하는 수. 출력시 값이 달라질 수 있는 형태.
            //변수의 선언
            // 키워드 해당키워드의 이름;
            // 키워드 : int(띄어쓰기)
            // 이름   : number
            // ;      : 세미콜론. 해당 코드가 끝났다.

            int number; // 변수의 선언. 정수를 저장할 수 있는 변수를 선언하는데 그 녀석의 이름이 number
            number = 10; // number 변수에 10을 대입.
            
            // 정수형 변수를 이름을 num으로 선언해서 그 변수에 100이라는 숫자를 넣어보세요.
            int num;
            num = 100;
           
            //초기화 : 변수의 선언과 동시에 데이터를 넣는 것
            int num2 = 200;
            Console.WriteLine(number);
            Console.WriteLine(num);
            Console.WriteLine(num2);

            Console.WriteLine(10+100);
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine(num3 + num4);
            Console.WriteLine(num3 - num4);
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num3 / num4);
            Console.WriteLine(num3 % num4);

            //키워드를 하나 선택 float
            //변수의 선언
            //변수의 초기화
            //변수의 사칙연산

            float f1 = 1.1f;
            float f2 = 2.3f;
            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);
            Console.WriteLine(f1 % f2);

            char c1 = 'c';
            char c2 = 'o';
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
            Console.WriteLine(c1 % c2);
            // 문자는 사실 숫자다.
            // a라는 숫자는 46이다.
            // 46 -> a
            // ASCII 코드에 이미 등록돼있다.

            string s1 = "문자열";

            string s2 = "처음 만들어보는 C# 프로그램";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s1 + s2);

            Console.Clear(); // 콘솔창을 비워주는 역할(기능)
            /*
            Console.WriteLine("두 수를 더해주는 프로그램입니다.");

            Console.Write(" 첫번째 숫자를 입력해주세요. : ");
            string input;
            input = Console.ReadLine();
            int inputNumber = int.Parse(input);

            Console.Write(" 두번째 숫자를 입력해주세요 : ");
            string inputA = Console.ReadLine();
            int inputNumber2 = int.Parse(inputA);

            Console.WriteLine("문자열의 덧셈 결과 : " + input + inputA);
            Console.WriteLine("정수의 덧셈 결과 : " + (inputNumber + inputNumber2));

            // 사용자의 입력을 받아서 두 수를 더하는 기능을 만들어본다.
            // 실수형 타입(float)받아서 프로그램을 구성하기.

            Console.WriteLine("float 값 3개를 입력 받아서 더하는 프로그램");

            Console.WriteLine("세 개의 실수를 더해주는 프로그램입니다.");

            Console.Write(" 첫 번째 실수를 입력해주세요 : ");
            string float1 = Console.ReadLine();
            float floatNumber1 = float.Parse(float1);

            Console.Write(" 두 번째 실수를 입력해주세요 : ");
            string float2 = Console.ReadLine();
            float floatNumber2 = float.Parse(float2);

            Console.Write(" 세 번째 실수를 입력해주세요 : ");
            string float3 = Console.ReadLine();
            float floatNumber3 = float.Parse(float3);

            Console.WriteLine("문자열의 덧셈 결과 : " + (float1 + float2 + float3));
            Console.WriteLine("실수의 덧셈 결과 : " + (floatNumber1 + floatNumber2 + floatNumber3));
            */
            //익숙해지기. int, float, char, string 입력을 받아서 출력해지는 것.

            //사각형의 넓이를 구하는 프로그램을 만들어 보자.

            Console.WriteLine("사각형의 넓이를 구하는 프로그램입니다.");

            Console.Write("가로의 크기를 입력해주세요 : ");
            string width = Console.ReadLine();
            int widthNumber = int.Parse(width);

            Console.Write("세로의 크기를 입력해주세요 : ");
            string height = Console.ReadLine();
            int heightNumber = int.Parse(height);

            Console.WriteLine($"사각형의 넓이 : {widthNumber * heightNumber}"); // 문자열 보관. 중괄호 안에 변수를 입력하는 방식으로 문자열을 표현 "{}"

            Console.WriteLine("원의 넓이를 구하는 프로그램입니다.");

            Console.Write("반지름의 길이를 입력해주세요 : ");
            string radius = Console.ReadLine();
            float radiusNumber = float.Parse(radius);

            Console.WriteLine($"원의 넓이 : {radiusNumber * radiusNumber * 3.14}");

        }
    }
}
