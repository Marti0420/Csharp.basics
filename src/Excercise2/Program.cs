using System;
using System.Collections.Generic;
using System.Data;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = CreateList();

            if (numbers.Count < 3)
            {
                Console.WriteLine("Not enough elements");
                return;
            }

            while (true)
            {
                Console.WriteLine("Choose operation:");
                Console.WriteLine("1. Find max");
                Console.WriteLine("2. Count even numbers");
                Console.WriteLine("3. Calculate average");
                Console.WriteLine("4. Write reverse");
                Console.WriteLine("Press q to quit..");

                var operation = Console.ReadLine();

                if (operation == "max")
                {
                    var max = FindMax(numbers);
                    Console.WriteLine($"Max number is {max}");
                }
                else if (operation == "even")
                {
                    var even = CountEvenNumbers(numbers);
                    Console.WriteLine($"Even numbers is {even}");
                }
                else if (operation == "avg")
                {
                    var avg = CalculateAverage(numbers);
                    Console.WriteLine($"Average is {avg}");
                }
                else if (operation == "rvs")
                {
                    WriteReverse(numbers);
                }
                else if (operation == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }
            }
        }

        static List<int> CreateList()
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

            return list;
        }

        static int FindMax(List<int> list)
        {
            var max = 0;
            
            foreach(var number in list)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        static int CountEvenNumbers(List<int> list)
        {
            var even = 0;

            foreach(var number in list)
            {
                if (number % 2 == 0)
                {
                    even++;
                }
            }

            return even;
        }

        static double CalculateAverage(List<int> list)
        {
            var sum = 0;

            foreach (var number in list)
            {
                sum += number;
            }

            return (double) sum / list.Count;
        }

        static void WriteReverse(List<int> list)
        {
            for (var i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}


 