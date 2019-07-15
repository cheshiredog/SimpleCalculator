using System;
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
                double firstNumber;
                double secondNumber;

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
                }
            }

            while (userAnswer != "stop");


        }
    }
}
