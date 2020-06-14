using System;

namespace _06_BitFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            // [Code Standard] 상수는 전체 대문자로. 
            const int BIT_FLAG_SIZE = 8;

            byte bitFlags = 0;

            byte mask1 = 1 << 2; // 1 을 << Shift 2 번이니 001 --> 100 으로 된다. 

            bitFlags |= mask1;
            
            // Padding 을 해야 0000 이 붙어서 나온당. ~! 
            Console.WriteLine($"bitFlags: {Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0')}");

            byte mask3 = (1 << 3) | (1 << 5);// 1 << 3 --> 8 , 1 << 5 --> 32 

            bitFlags |= mask3;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= (byte)~mask1; // & : And 기호고... Not Mask 111111 이니 , 그대로  

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0') + "May be : 10100 ? ");

            bitFlags &= 0; // 

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0') + "May be : 0 ? ");

            char char1 = 'A';
            int result1 = char1 | ' ';

            Console.WriteLine("result1: " + (char)result1);

            char char2 = 'a';
            int result2 = char2 & '_';

            Console.WriteLine("result2: " + (char)result2);
        }
    }
}
