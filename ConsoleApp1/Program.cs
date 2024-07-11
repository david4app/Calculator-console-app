using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator\n");

            while (true)
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Select an operation:");
                    Console.WriteLine("1. Addition (+)");
                    Console.WriteLine("2. Subtraction (-)");
                    Console.WriteLine("3. Multiplication (*)");
                    Console.WriteLine("4. Division (/)");
                    Console.WriteLine("5. Modulus (%)");

                    Console.Write("Enter your choice (1-5): ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    double result = 0;
                    bool validOperation = true;

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
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                                validOperation = false;
                            }
                            break;
                        case 5:
                            if (num2 != 0)
                            {
                                result = num1 % num2;
                                Console.WriteLine($"Result: {num1} % {num2} = {result}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Modulus by zero is not allowed.");
                                validOperation = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid operation.");
                            validOperation = false;
                            break;
                    }

                    if (validOperation)
                    {
                        Console.WriteLine("\nDo you want to perform another calculation? (yes/no): ");
                        string continueCalc = Console.ReadLine().ToLower();
                        if (continueCalc != "yes")
                        {
                            break;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter numeric values.");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    }
}
