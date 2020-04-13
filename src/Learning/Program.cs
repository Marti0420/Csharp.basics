using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When did you go to sleep?");
            var textSleepHour = Console.ReadLine();
            var sleepHour = Convert.ToInt16(textSleepHour);
            
            Console.WriteLine("When did you get up?");
            var textWakeHour = Console.ReadLine();
            var wakeHour = Convert.ToInt16(textWakeHour);

            var sleepTime = 24 - sleepHour + wakeHour;

            if (sleepTime >= 12)
            {
                Console.WriteLine($"You slept too much. {sleepTime} hours");
            }
            else if (sleepTime >= 9)
            {
                Console.WriteLine($"You slept good");
            }
            else if (sleepTime >= 4)
            {
                Console.WriteLine($"You must go to sleep, dude");
            }
            else
            {
                Console.WriteLine($"It was a nap");
            }
        }
    }
}