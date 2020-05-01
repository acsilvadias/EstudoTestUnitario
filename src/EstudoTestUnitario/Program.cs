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
        public static double ConverterMedidas(MeasureType DistanciaTo, double distancia)
        {

            return new ConvertMeasures.Converter().ToConvert(DistanciaTo, distancia);
        }
    }
}
