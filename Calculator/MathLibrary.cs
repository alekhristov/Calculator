using System;
using System.Collections.Generic;

namespace Calculator
{
    class MathLibrary
    {
        private readonly MathOperations m_Sum;
        private readonly MathOperations m_Subtract;
        private readonly MathOperations m_Multiply;
        private readonly MathOperations m_Divide;
        private readonly Dictionary<char, MathOperations> m_Commands = new Dictionary<char, MathOperations>();

        public MathLibrary(MathOperations sum, MathOperations subtract, MathOperations multiply, MathOperations divide)
        {
            m_Sum = sum;
            m_Subtract = subtract;
            m_Multiply = multiply;
            m_Divide = divide;
            m_Commands['+'] = m_Sum;
            m_Commands['-'] = m_Subtract;
            m_Commands['*'] = m_Multiply;
            m_Commands['/'] = m_Divide;
        }

        public decimal PerformACertainOperation(char operation)
        {
            try
            {
                return m_Commands[operation].Result();
            }
            catch (KeyNotFoundException ex)
            {
                throw new InvalidOperationException("ERROR! Wrong input! Please enter a valid operator(+, -, *, /).", ex);               
            }

        }
    }
}
