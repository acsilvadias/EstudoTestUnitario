using EstudoTestUnitario;
using System;
using Xunit;
using EstudoTestUnitario.Enums;
using System.ComponentModel.DataAnnotations;

namespace TestConvertMeasures
{
    public class TestConvertersMeasures
    {
        [Theory]
        [InlineData(MeasureType.Miles,21, 33684)]
        [InlineData(MeasureType.kilometer, 1800,1.8)]
        public void TestConvertToCentimeter( MeasureType to, double valorDe, double esperado)
        {
            double resultado = ConverteMedidas.ConverterMedidas(to, valorDe);
            Assert.Equal(esperado, resultado);


        }
    }
}

