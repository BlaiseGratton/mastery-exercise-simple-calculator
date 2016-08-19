using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parser
    {
        private char[] operators = new char[] { '-', '+', '*', '/', '%' };

        public Expression Parse(string input)
        {
            var result = new Expression();
            bool validInput = true;
            int operand = -1;
            int _operator = -1;
            char operation = '0';

            try
            {
                var splitNumbers = input.Split(operators);
                validInput = splitNumbers.Length == 2;
                operand = int.Parse(splitNumbers[0]);
                _operator = int.Parse(splitNumbers[1]);
                operation = input[splitNumbers[0].Length];
            }
            catch (Exception e)
            {
                validInput = false;
            }
            if (!validInput)
                throw new ArgumentException("Given expression is not valid");
            return new Expression(operand, operation, _operator);
        }
    }
}
