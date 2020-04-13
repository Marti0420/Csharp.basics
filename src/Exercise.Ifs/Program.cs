using System;

namespace Exercise.Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            var textNumber = Console.ReadLine();
            var number = Convert.ToDecimal(textNumber);

            Console.WriteLine("Pick a second number");
            var textSecondNumber = Console.ReadLine();
            var secondNumber = Convert.ToDecimal(textSecondNumber);

            Console.WriteLine("Chose +, -");
            var operation = Console.ReadLine();

            if (operation == "+")
            {
                var sum = number + secondNumber;
                Console.WriteLine($"Your result is {sum}");
            }
            else if (operation == "-")
            {
                var difference = number - secondNumber;
                Console.WriteLine($"Your result is {difference}");
            }
            else if (operation == "*")
            {
                var multiplaying = number * secondNumber;
                Console.WriteLine($"Your result is {multiplaying}");
            }
            else if (operation == "/")
            {
                var division = number / secondNumber;
                Console.WriteLine($"Your result is {division}");
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }
    }
}     