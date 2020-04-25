namespace task_Converter
{
    public abstract class Converter
    {
        public double Value { get; set; }
        public string ConversionType { get; set; }


        public Converter(double value, string conversionType)
        {
            Value = value;
            ConversionType = conversionType;
        }
        public abstract void SelectConversion(string conversionType);
    }
}
