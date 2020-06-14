using System;

namespace _07_BitwiseMultiplicationAndDividation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;

            int result1 = num1 << 1; // 10  - 2 

            Console.WriteLine($"result1 : {result1}");

            int result2 = result1 << 2; // 1000 - 8

            Console.WriteLine($"result2 : {result2}");

            int result3 = result2 >> 2; // 10 - 2

            Console.WriteLine($"result3 : {result3}");
        }
    }
}
