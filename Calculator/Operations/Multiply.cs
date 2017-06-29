using System;

namespace Calculator
{
    public class Multiply : MathOperations
    {
        public Multiply(decimal firstNumber, decimal secondNumber)
            : base(firstNumber, secondNumber)
        {
        }

        public override decimal Result()
        {
            return firstNumber * secondNumber;
        }
    }
}
