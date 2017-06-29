using System;

namespace Calculator
{
    public abstract class MathOperations
    {
        public readonly decimal firstNumber;
        public readonly decimal secondNumber;

        public MathOperations(decimal firstNumber, decimal secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public abstract decimal Result();

    }
}
