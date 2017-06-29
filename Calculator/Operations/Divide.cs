using System;

namespace Calculator
{
    public class Divide : MathOperations
    {
        public Divide(decimal firstNumber, decimal secondNumber)
            : base(firstNumber, secondNumber)
        {
        }

        public override decimal Result()
        {
            if (secondNumber == 0)
            {
                throw new ArgumentException("Not a number! You can not divide by zero!");
            }

            return firstNumber / secondNumber;
        }
    }
}
