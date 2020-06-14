using System;

namespace _03_PrimitiveTypesToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteMax = byte.MaxValue;
            byte byteMin = byte.MinValue;

            int intMax = int.MaxValue;
            int intMin = int.MinValue;

            long longMax = long.MaxValue;
            long longMin = long.MinValue;

            char charMax = char.MaxValue;
            char charMin = char.MinValue;

            Console.WriteLine($"{byteMin} -> {Convert.ToString(byteMin, 2)}");
            Console.WriteLine($"{byteMax} -> {Convert.ToString(byteMax, 2)}");

            Console.WriteLine($"{intMin} -> {Convert.ToString(intMin, 2)}");
            Console.WriteLine($"{intMax} -> {Convert.ToString(intMax, 2)}");

            Console.WriteLine($"{longMin} -> {Convert.ToString(longMin, 2)}");
            Console.WriteLine($"{longMax} -> {Convert.ToString(longMax, 2)}");

            // Char Set - 2 Byte ? 
            // C# - Char is Unicode (2 Byte)
            // Other Language - Ascii Code ( 1 Byte)
            Console.WriteLine($"{charMin} -> {Convert.ToString(charMin, 2)}");
            Console.WriteLine($"{charMax} -> {Convert.ToString(charMax, 2)}");


        }
    }
}
