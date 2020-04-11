using System;
using System.Security.Claims;
using System.Threading.Channels;

namespace Ifs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            var textAge = Console.ReadLine();
            var age = Convert.ToUInt16(textAge);

            var isAgeEven = age % 2 == 0;

            if (isAgeEven)
            {
                Console.WriteLine("Your age is evens");
            }

            if (age >= 100)
            {
                Console.WriteLine("WTF");
            }
            else if (age >= 60)
            {
                Console.WriteLine("You're old");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You're an adult");
            }
            else
            {
                Console.WriteLine("You're a child ;/");
            }

            Console.WriteLine($"Hello {name}, your age is {age}");
        }
        
        
    }
}
    
        
            