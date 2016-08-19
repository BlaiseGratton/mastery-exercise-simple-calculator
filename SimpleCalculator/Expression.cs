using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        public readonly int Operand;
        public readonly char Operation;
        public readonly int Operator;

        public Expression(int operand, char operation, int _operator)
        {
            if (operand < 1 || _operator < 1)
                throw new ArgumentException("Positive numbers only");
            Operand = operand;
            Operator = _operator;
            if ("+-*/%".IndexOf(operation) == -1)
                throw new ArgumentException("Illegal operation requested");
            else
                Operation = operation;
        }

        public Expression() { }
    }
}
