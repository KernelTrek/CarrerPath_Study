using System;

namespace _15_OrderOfExpressionEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 15;
            int num3 = 2;

            int max1 = num1;
            if (num2 > num1)
            {
                max1 = num2;
            }

            if(num3 > max1)
            {
                max1 = num3;
            }

            Console.WriteLine($"max1 : {max1}");

            // max 값 찾기
            int max2 = num1;

            max2 = num2 > max2 ? num2 : max2;
            max2 = num3 > max2 ? num3 : max2;

            Console.WriteLine($"max2 : {max2}");

        }
    }
}
