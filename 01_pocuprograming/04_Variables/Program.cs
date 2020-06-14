using System;

namespace _04_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code Standard
            // Local Variable - Camel Case 
            int int1 = 2;
            int int2 = 10;


            // What Is "f" ?
            // f는 접미어(postfix) 로 C# 에서는 기본 자료형이 Double 형이다 보니,
            // float 의 경우 f를 붙여 준다. 
            float float1 = 10.23f;
            float float2 = 3.4f;

            double double1 = 11.0;
            double double2 = 5.234;

            char char1 = 'x';
            char char2 = '$';

            // Char 는 기본이 Ascii 이다 ... 그런데 혹시... 300 은 어떤 문자일까 ?
            // 129 부터 ? 가 되는 것으로 봐서, EUC-KR 이나 기타 기능들도 지원하지 않는 것 같다. 
            char testChar = (char)300;

            Console.WriteLine($"{int1} + {int2} = {int1 + int2}");
            Console.WriteLine($"{int2} + {int1} = {int2 - int1}");
            Console.WriteLine($"{float1} + {float2} = {float1 + float2}");
            Console.WriteLine($"{double1} + {double2} = {double1 + double2}");
            Console.WriteLine($"{char1} + {char2} = {char1 + char2}");
            Console.WriteLine($"char set 300 ? {testChar}"); // 그냥 ? 네... 안쓰나.. 

        }
    }
}
