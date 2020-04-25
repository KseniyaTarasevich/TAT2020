using System;

namespace task_Converter
{
    public class ConverterFactory
    {

        public Converter Converter;

        public Converter SelectConverter(double value, string conversionType)
        {
            if (conversionType == "CF")
            {
                Converter = new TemperatureConverter(value, conversionType);
            }

            if (conversionType == "FC")
            {
                Converter = new TemperatureConverter(value, conversionType);
            }

            if (conversionType == "MF")
            {
                Converter = new DistanceConverter(value, conversionType);
            }

            if (conversionType == "FM")
            {
                Converter = new DistanceConverter(value, conversionType);
            }

            return Converter;
        }
    }
}
