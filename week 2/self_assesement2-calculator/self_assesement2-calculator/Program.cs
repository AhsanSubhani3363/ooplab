using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assesement2_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            Calculator calc = new Calculator(num1, num2);


            Console.WriteLine("\nResults:");
            Console.WriteLine("Addition: " + calc.Add());
            Console.WriteLine("Subtraction: " + calc.Subtract());
            Console.WriteLine("Multiplication: " + calc.Multiply());
            Console.WriteLine("Division: " + calc.Divide());
        }

    }
    }

