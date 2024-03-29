﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            string userAnswer;

            do
            {
                Console.Write("\nSelect operation: +, -, *, /, ^, sqrt. Enter \"stop\", if you want to close calculator: ");
                userAnswer = Console.ReadLine();
                double firstNumber, secondNumber;

                switch (userAnswer)
                {
                    case "+":
                        Console.Write("\nEnter first number: ");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;

                    case "-":
                        Console.Write("\nEnter first number: ");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;

                    case "*":
                        Console.Write("\nEnter first number: ");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        break;

                    case "/":
                        Console.Write("\nEnter first number: ");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        secondNumber = Convert.ToDouble(Console.ReadLine());

                        if (secondNumber == 0)
                        {
                            Console.WriteLine("The second number cannot be zero.");
                            break;
                        }

                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                        break;

                    case "^":
                        Console.Write("\nEnter a number: ");
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter a exponent: ");
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{firstNumber} ^ {secondNumber} = {Math.Pow(firstNumber, secondNumber)}");
                        break;

                    case "sqrt":
                        Console.Write("\nEnter a number: ");
                        firstNumber = Convert.ToDouble(Console.ReadLine());

                        if (firstNumber < 0)
                        {
                            Console.WriteLine("It is impossible to extract the square root of a negative number.");
                            break;
                        }

                        Console.WriteLine($"sqrt({firstNumber}) = {Math.Sqrt(firstNumber)}");
                        break;

                    case "stop":
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Unknown operation.");
                        break;
                }
            }

            while (userAnswer != "stop");


        }
    }
}
