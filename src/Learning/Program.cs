using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert sleep time");
            var textSleepTime = Console.ReadLine();
            var sleepTime = Convert.ToInt32(textSleepTime);

            if (sleepTime >= 12)
            {
                Console.WriteLine($"I slept too much, I have a headache");
            }
            else if (sleepTime >= 9)
            {
                Console.WriteLine($"I slept good");
            }
            else if (sleepTime >= 4)
            {
                Console.WriteLine($":/");
            }
            else
            {
                Console.WriteLine($"It was a nap");
            }
        }
    }
}