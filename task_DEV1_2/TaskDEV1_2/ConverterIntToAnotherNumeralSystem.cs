using System;
using System.Collections;

namespace TaskDEV1_2
{
    public class ConverterIntToAnotherNumeralSystem
    {
        public string ConvertToAnotherNumeralSystem(string consoleNumber, string consoleSystemBase)
        {
            if (Convert.ToInt32(consoleSystemBase) < 2 || Convert.ToInt32(consoleSystemBase) > 20)
            {
                throw new ArgumentOutOfRangeException("Base of new system must be between 2 and 20");
            }

            if (Convert.ToInt32(consoleNumber) < Int32.MinValue || Convert.ToInt32(consoleNumber) > Int32.MaxValue)
            {
                throw new OutOfMemoryException("Entered number must be bigger than Int32.MinValue and smaller than Int32.MaxValue");
            }

            if (consoleNumber == null || consoleNumber == string.Empty || consoleSystemBase == null || consoleSystemBase == string.Empty)
            {
                throw new Exception("Invalid values of number or base of a system");
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
                numberInNewSystem += GetLettersInNewNumeralSystem(newNumberByDigits[i].ToString());
            }

            return numberInNewSystem;
        }

        public string GetLettersInNewNumeralSystem(string elementOfNewNumber)
        {
            string lettersForNumberInAnotherSystem = "ABCDEFGHIJ";
            string newNumberWithLetters = string.Empty;


            if (Convert.ToInt32(elementOfNewNumber) >= 10)
            {
                newNumberWithLetters += lettersForNumberInAnotherSystem.Substring(Convert.ToInt32(elementOfNewNumber) - 10, 1);
                return newNumberWithLetters;
            }

            else
            {
                return elementOfNewNumber;
            }
        }
    }
}
