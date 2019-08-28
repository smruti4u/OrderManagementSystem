using System;
using System.Collections.Generic;
using System.Text;

namespace MathsLibrary
{
    public class Calculator
    {
        private readonly IMathLibrary mathLibrary;
        public Calculator(IMathLibrary mathLibrary)
        {
            this.mathLibrary = mathLibrary;
        }

        public int Calculate(OperationType operationType)
        {
            int result = 0;

            if (operationType == OperationType.Add)
                result =  mathLibrary.Add(12, 23);

            if (mathLibrary.doCalculation)
                result =  60;

            if (operationType == OperationType.Multiply)
                result =  mathLibrary.Multiply(12, 23);

            return result;
        }
    }
}
