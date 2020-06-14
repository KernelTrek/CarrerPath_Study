using System;

namespace _14_LogicalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            bool expression1 = !(num1 == num2 && num1 != num3);
            bool expression2 = num1 != num2 || num1 == num3;

            Console.WriteLine($"expression1 : {expression1}");
            Console.WriteLine($"expression2 : {expression2}");

            bool expression3 = num1 > num2 || num1 == num3 || ++num1 > num2;
            Console.WriteLine($"expression3 : {expression3}");
        }
    }
}

