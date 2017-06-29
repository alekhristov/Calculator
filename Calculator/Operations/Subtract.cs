using System;

namespace Calculator
{
    public class Subtract : MathOperations
    {
        public Subtract(decimal firstNumber, decimal secondNumber)
         : base(firstNumber, secondNumber)
        {
        }

        public override decimal Result()
        {
            return firstNumber - secondNumber;
        }
    }
}
