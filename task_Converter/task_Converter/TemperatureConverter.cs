using System;

namespace task_Converter
{

    public class TemperatureConverter : Converter
    {
        private const double _C0NVERSION_COEFFICIENT = 1.8;
        private const int _C0NVERSION_SUMMAND = 32;

        public TemperatureConverter(double value, string conversionType) : base(value, conversionType) { }

        public double ConvertCelsiusToPharyngate()
        {
            return (_C0NVERSION_COEFFICIENT * Value) + _C0NVERSION_SUMMAND;
        }

        public double ConvertPharyngateToCelsius()
        {
            return (Value - _C0NVERSION_SUMMAND) / _C0NVERSION_COEFFICIENT;
        }

        public override void SelectConversion(string conversionType)
        {
            switch (conversionType)
            {
                case "CF":
                    Console.WriteLine(ConvertCelsiusToPharyngate());
                    break;
                case "FC":
                    Console.WriteLine(ConvertPharyngateToCelsius());
                    break;
            }
        }
    }
}