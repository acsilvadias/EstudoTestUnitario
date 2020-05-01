using EstudoTestUnitario.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoTestUnitario.ConvertMeasures
{
    interface IConverterFactory
    {
       double ToConvert(MeasureType measureTypeTo, double measure);

    }
}
