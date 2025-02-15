using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assesement2_calculator
{
    internal class Calculator
    {
        public double number1, number2;


        public Calculator(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public double Add()
        {
            return number1 + number2;
        }


        public double Subtract()
        {
            return number1 - number2;
        }


        public double Multiply()
        {
            return number1 * number2;
        }


        public double Divide()
        {
            if (number2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return number1 / number2;
        }
    }
}


    
