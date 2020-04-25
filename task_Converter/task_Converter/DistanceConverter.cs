using System;

namespace task_Converter
{
    public class DistanceConverter : Converter
    {
        private const double _C0NVERSION_COEFFICIENT = 0.304800610;
        public DistanceConverter(double value, string conversionType) : base(value, conversionType) { }
       
        public double ConvertMetersToFeet()
        {
            return Value / _C0NVERSION_COEFFICIENT;
        }
        public double ConvertFeetToMeters()
        {
            return Value * _C0NVERSION_COEFFICIENT;
        }

        public override void SelectConversion(string type)
        {
            switch (type)
            {
                case "MF":
                    Console.WriteLine(ConvertMetersToFeet());
                    break;
                case "FM":
                    Console.WriteLine(ConvertFeetToMeters());
                    break;
            }
        }
    }
}
