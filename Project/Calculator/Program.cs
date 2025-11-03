using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculation");

            for (; ; )
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1) Addition (+)");
                Console.WriteLine("2) Subtraction (-)");
                Console.WriteLine("3) Multiplication (*)");
                Console.WriteLine("4) Division (/)");
                Console.Write("Enter option (1-4): ");

                string input = Console.ReadLine();
                int choice;

                if (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please try again!");
                    continue;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero not allowed!");
                            continue;
                        }
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        break;
                }
            }
        }
    }
}
