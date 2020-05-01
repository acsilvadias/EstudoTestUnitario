using EstudoTestUnitario.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EstudoTestUnitario.ConvertMeasures
{
    public class Converter : IConverterFactory
    {

        public double ToConvert(MeasureType measureTypeTo, double measure)
        {

            switch (measureTypeTo)
            {
                case MeasureType.centimeter:
                    return ToCentimeter(measure);
                
                case MeasureType.meter:
                    return ToMeter(measure);

                case MeasureType.kilometer:
                    return ToKilometer(measure);

                case MeasureType.Miles :
                    
                    return ToMiles(measure);

                default:
                    throw new NotFiniteNumberException();
            }


        }

        private double ToCentimeter(double measureMillimeter)
        {
            return (double)(measureMillimeter / 10);
        }
        private double ToKilometer(double measureMeter)
        {
            return (double)(measureMeter / 1000);
        }

        private double ToMeter(double measureCentimeter)
        {
            return (double)(measureCentimeter / 100);
        }

        private double ToMiles(double measureKilometer)
        {
            return (double)(measureKilometer * 1604) ;
        }
    }
}
