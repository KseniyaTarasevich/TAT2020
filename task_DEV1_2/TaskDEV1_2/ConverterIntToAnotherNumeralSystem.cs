using System;
using System.Collections;

namespace TaskDEV1_2
{
    /// <summary>
    /// Class for converting numbers
    /// </summary>
    public class ConverterIntToAnotherNumeralSystem
    {
        private const int _minSystemBase = 2;
        private const int _maxSystemBase = 20;
        private const string _lettersForNumberInAnotherSystem = "ABCDEFGHIJ";

        /// <summary>
        /// Method for converting numbers in decimal system to another base systems
        /// </summary>
        /// <param Convertible number = "consoleNumber"></param>
        /// <param base of a new system = "consoleSystemBase"></param>
        /// <returns>Number in new numeral system as a string</returns>
        public string ConvertToAnotherNumeralSystem(string consoleNumber, string consoleSystemBase)
        {
            if (Convert.ToInt32(consoleSystemBase) < _minSystemBase || Convert.ToInt32(consoleSystemBase) > _maxSystemBase)
            {
                throw new ArgumentOutOfRangeException("Base of new system must be between 2 and 20");
            }

            if (Convert.ToInt32(consoleNumber) < Int32.MinValue || Convert.ToInt32(consoleNumber) > Int32.MaxValue ||
                Convert.ToInt32(consoleSystemBase) < Int32.MinValue || Convert.ToInt32(consoleSystemBase) > Int32.MaxValue)
            {
                throw new OverflowException("Entered number must be bigger than Int32.MinValue and smaller than Int32.MaxValue");
            }

            if (consoleNumber == null || consoleNumber == string.Empty || consoleSystemBase == null || consoleSystemBase == string.Empty)
            {
                throw new FormatException("Invalid values of number or base of a system");
            }

            if (Convert.ToInt32(consoleNumber) < 0)
            {
                throw new ArgumentOutOfRangeException("Entered number must be non-negative");
            }

            string numberInNewSystem = string.Empty;
            int convertibleNumber = Convert.ToInt32(consoleNumber);

            if (!Int32.TryParse(consoleNumber, out convertibleNumber))
            {
                throw new FormatException("Entered number doesn't match the expected type");
            }

            if (convertibleNumber == 0)
            {
                return "0";
            }

            int partOfANumber = Convert.ToInt32(consoleNumber);
            ArrayList newNumberByDigits = new ArrayList();

            while (partOfANumber > 0)
            {
                partOfANumber = partOfANumber / Convert.ToInt32(consoleSystemBase);
                newNumberByDigits.Add(Convert.ToInt32(convertibleNumber) % Convert.ToInt32(consoleSystemBase));
                convertibleNumber = partOfANumber;
            }

            for (int i = newNumberByDigits.Count - 1; i >= 0; i--)
            {
                numberInNewSystem += GetLetterInNewNumeralSystem(newNumberByDigits[i].ToString());
            }

            return numberInNewSystem;
        }

        /// <summary>
        /// Method for converting number when base of new system more than 10
        /// </summary>
        /// <param One digit of the number = "elementOfNewNumber"></param>
        /// <returns>Number in another system with letters</returns>
        public string GetLetterInNewNumeralSystem(string elementOfNewNumber)
        {
            string newNumberWithLetters = string.Empty;

            if (Convert.ToInt32(elementOfNewNumber) >= 10)
            {
                newNumberWithLetters += _lettersForNumberInAnotherSystem.Substring(Convert.ToInt32(elementOfNewNumber) - 10, 1);
                return newNumberWithLetters;
            }

            else
            {
                return elementOfNewNumber;
            }
        }
    }
}
