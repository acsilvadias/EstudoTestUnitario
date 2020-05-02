using System;
using Xunit;
using EstudoTestUnitario.Enums;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using EstudoTestUnitario;

namespace TestConvertMeasures
{
    public class TestOperationsMath
    {
        [Fact]
        public void TestOperationMathSum()
        {
            double resultado = OperacoesMatematicas.Operacao(OperationType.Sum, 10, 3);

            Assert.Equal(13, resultado);
        }
    }
}
