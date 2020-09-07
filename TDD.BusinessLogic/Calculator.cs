using System;

namespace TDD.BusinessLogic
{
    public class Calculator
    {
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Multiply(in double num1, in double num2)
        {
            return num1 * num2;
        }

        public double Divide(in double num1, in double num2)
        {
            if (num2 == 0)
                throw new ArgumentException("Cannot divide by 0!");
            return num1 / num2;
        }
    }
}