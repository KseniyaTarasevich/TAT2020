using System;

namespace TaskDev1_1
{
    /// <summary>
    /// Class for working with console
    /// </summary>
    public class WorkWithConsole
    {
        string consoleString;
        SelectorOfMaximumDifferentSymbols selector = new SelectorOfMaximumDifferentSymbols();

        /// <summary>
        /// Method for input user string
        /// </summary>
        public void ConsoleInput()
        {
            Console.Write("Enter your string: ");
            consoleString = Console.ReadLine();
        }

        /// <summary>
        /// Method for output answer to console
        /// </summary>
        public void ConsoleOutput()
        {
            int answer;
            answer = selector.MaximumNumberOfDifferentSymbols(consoleString);
            Console.Write("Maximum number of different consecutive symbols: ");
            Console.Write(answer);
        }
    }
}