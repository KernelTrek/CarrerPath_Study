using System;

namespace _09_IncrementAndDecrementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 10;

            int result1 = num1++ + num2; // 10  post , 1 , 10

            Console.WriteLine("num1: " + num1); // 1
            Console.WriteLine("num2: " + num2); // 10
            Console.WriteLine("result1: " + result1); // 10

            num1 = 0;
            num2 = 10;

            int result2 = ++num1 + num2++; // 1 + 10 -> 11

            Console.WriteLine("num1: " + num1); // 1 
            Console.WriteLine("num2: " + num2); // 11
            Console.WriteLine("result2: " + result2); // 12

            num1 = 0;
            num2 = 10;

            int result3 = num1-- + num1-- - --num2; // 0 -1 - 9 = - 10

            Console.WriteLine("num1: " + num1); // -2
            Console.WriteLine("num2: " + num2); // 9
            Console.WriteLine("result3: " + result3); // - 10

            num1 = 0;
            num2 = 10;

            int result4 = num2++ * num1++ - --num2 + num1; // 10 * 0 - 10 + 1 -- -9

            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
            Console.WriteLine("result4: " + result4);
        }
    }
}
