using System;

namespace TaskDEV1_2
{
    class WorkWithConsole
    {
        string consoleNumber;
        string consoleSystemBase;
        ConverterIntToAnotherNumeralSystem converter = new ConverterIntToAnotherNumeralSystem();

        public void ConsoleInput()
        {
            Console.Write("Enter your number in decimal system: ");
            consoleNumber = Console.ReadLine();
            Console.Write("Enter new base: ");
            consoleSystemBase = Console.ReadLine();
        }

        public void ConsoleOutput()
        {
            string answer;
            answer = converter.ConvertToAnotherNumeralSystem(consoleNumber, consoleSystemBase);
            Console.Write("Number in " + consoleSystemBase + " numeral system: " + answer);
        }
    }
}