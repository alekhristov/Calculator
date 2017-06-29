using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Calculate: ");
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var resultSummary = new List<string>();

            while (input[0] != "q")
            {

                try
                {
                    char operation = char.Parse(input[1]);
                    decimal firstNumber = decimal.Parse(input[0]);
                    decimal secondNumber = decimal.Parse(input[2]);

                    var mathLibrary = new MathLibrary(
                        new Sum(firstNumber, secondNumber),
                        new Subtract(firstNumber, secondNumber),
                        new Multiply(firstNumber, secondNumber),
                        new Divide(firstNumber, secondNumber));

                    decimal result = mathLibrary.PerformACertainOperation(operation);

                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");

                    resultSummary.Add($"({firstNumber} {operation} {secondNumber} = {result})");
                }

                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input! Please enter input in the correct format! (ex. 1 + 1)");
                }

                Console.WriteLine("\r\nPress 'q' to quit the calculator and see recently performed operations.");
                Console.Write("\r\nCalculate: ");

                input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine("\r\nRecently performed operations:");

            Console.WriteLine(string.Join("\r\n", resultSummary));
            Console.ReadLine();
        }
    }
}
