using System;

namespace TaskDEV1_2
{
    /// <summary>
    /// Class for working with console 
    /// </summary>
    class WorkWithConsole
    {
        string consoleNumber;
        string consoleSystemBase;
        ConverterIntToAnotherNumeralSystem converter = new ConverterIntToAnotherNumeralSystem();

        /// <summary>
        /// Method for input base of a system and number
        /// </summary>
        public void ConsoleInput()
        {
            Console.Write("Enter your number in decimal system: ");
            consoleNumber = Console.ReadLine();
            Console.Write("Enter new base: ");
            consoleSystemBase = Console.ReadLine();
        }

        /// <summary>
        /// Method for output number in other numeral system
        /// </summary>
        public void ConsoleOutput()
        {
            string answer;
            answer = converter.ConvertToAnotherNumeralSystem(consoleNumber, consoleSystemBase);
            Console.Write("Number in " + consoleSystemBase + " numeral system: " + answer);
        }
    }
}