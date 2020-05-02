using System;

namespace EstudoTestUnitario
{
    using Enums;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public static class ConverteMedidas
    {
        public static double ConverterMedidas(MeasureType typeMeasure, double distancia)
        {

            return new ConvertMeasures.Converter().ToConvert(typeMeasure, distancia);
        }
    }

    public static class OperacoesMatematicas
    {
        public static double Operacao(OperationType typeOperation , double value1, double value2)
        {

            return new OperationsMath.Operation().execute(typeOperation, value1, value2);
        }
    }
}
