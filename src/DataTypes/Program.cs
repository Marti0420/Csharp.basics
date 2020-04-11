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
            double doubleNumber = 21.37; // body weight
            decimal decimalNumber = 21.37m; // money
            
            
            //text
            
            char letter = 'a';
            string text = "ab cde";
            
            //logical
            bool @true = true;
            bool @false = false;
            
            var number2 = 21.37m; //type taken from right sight of the equality operator
            
            // Operators

            var sum = 2 + number;
            var difference = sum - 2;
            var multiplying = 2 * 2;
            var division = 2 / 2;
            var modulo = 5 % 2;

            var negation = !true;
            var alternative = true || false; // OR
            var conjuction = true && false; // AND 

            var shortCircled = false & PrintText();
            
            Console.WriteLine("Hello World!");
        }

        static bool PrintText()
        {
            Console.WriteLine("HELLO");
            return false;
        }
    }
} 