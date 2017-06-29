using System;

namespace Calculator
{
    public class Sum : MathOperations
    {
        public Sum(decimal firstNumber, decimal secondNumber)
            : base(firstNumber, secondNumber)
        {
        }

        public override decimal Result()
        {
            return firstNumber + secondNumber;
        }

    }
}
