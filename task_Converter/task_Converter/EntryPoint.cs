using System;

namespace task_Converter
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {

                    throw new ArgumentException("Must be 2 arguments");

                }

                double number = Convert.ToDouble(args[0]);
                string type = args[1];
                var ConverterFactory = new ConverterFactory();
                var Converter = ConverterFactory.SelectConverter(number, type);
                Converter.SelectConversion(type);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Must be 2 arguments");
            }
        }
    }
}