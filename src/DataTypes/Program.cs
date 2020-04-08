using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //numbers

            short shortNumber = 2; // 16 bits
            int number = 1; // 32 bits 
            long longNumber = 2; // 64 bits

            byte byteNumber = 255; // 8 bits
            ushort ushortNumber = 10; // always positive 
            uint uintNumber = 20; // always positive
            ulong ulongNumber = 20; // always positive

            float floatNumber = 21.37f; 
            double doubleNumber = 21.37; // body wight
            decimal decimalNumber = 21.37m; // money
            
            
            //text
            
            char letter = 'a';
            string text = "ab cde";
            
            //logical
            bool @true = true;
            bool @false = false;
            
            Console.WriteLine("Hello World!");
        }
    }
}