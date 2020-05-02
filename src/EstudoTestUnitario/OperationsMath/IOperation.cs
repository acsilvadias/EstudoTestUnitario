using EstudoTestUnitario.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoTestUnitario.OperationsMath
{
    interface IOperation
    {
        double execute(OperationType typeOperation, double firstValue, double secondValue, int totalDecimal = 0);
    }
}
