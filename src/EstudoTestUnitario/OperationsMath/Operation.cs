using EstudoTestUnitario.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoTestUnitario.OperationsMath
{
    class Operation : IOperation
    {
        public double execute(OperationType typeOperation, double firstValue, double secondValue, int TotalDecimal = 0)
        {
            switch (typeOperation)
            {
                case OperationType.Sum:
                   
                    return ToSum(firstValue, secondValue);

                default:
                    throw new NotFiniteNumberException();
            }
        }

        private double ToSum(double firstValue, double secondValue, int totalDecimal = 0)
        {
            return Math.Round((firstValue + secondValue),totalDecimal);
        }
    }
}
