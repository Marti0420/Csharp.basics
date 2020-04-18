using System;
using System.Collections.Generic;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();


            while (true)
            {
                Console.WriteLine("Pick a numbers");
                var textNumber = Console.ReadLine();
                if (textNumber == "q")
                {
                    break;
                }

                var number = Convert.ToInt32(textNumber);
                list.Add(number);

            }
            
        }

        static int FindMax(List<int> list)
        {
            var max = 0;
            foreach (var number in list)
            {
                if (number > max)
                {
                    max = number;
                }

                return max;
            }
        }

        static int FindEvenNumbers(List<int> list)
        {
            var even = 0;
            
            foreach (var number in list)
            {
                if (number % 2 == 0)
                {
                    even++;
                }

                return even;
                
            }
        }

        static int CalculateArithmeticOfNumbers(List<int> list)
        {
            var Arithmetic = 0;

            foreach (var number in list)
            {
                
            }
        }
    }
}