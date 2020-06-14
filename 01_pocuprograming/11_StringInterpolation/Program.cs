using System;

namespace _11_StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 48; // This is Magic Number [What's This ? ]
            int num2 = 65; // This is Magic Number [What's This ? ]


            // Console.WriteLine 의 3가지 특징 
            Console.WriteLine("The sum of " + num1  + " and " + num2 + " is " + (num1 + num2) );
            Console.WriteLine("The sum of {0} and {1} is {2}", num1 , num2 , num1 + num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");

            // @ 로 표시하면 그냥 표시 된다.
            Console.WriteLine($"\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");
            Console.WriteLine(@"\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");

            // 문자열 보간 쪼아 ~! 
            Console.WriteLine("{0, -11} + {1, 11} = {2}", num1, num2, num1 + num2);
            Console.WriteLine($"{num1,-11} + {num2,11} = {num1 + num2}");


        }
    }
}
