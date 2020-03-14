using System;

namespace TaskDev1
{
    /// <summary>
    /// Class for working with console
    /// </summary>
    public class WorkWithConsole
    {
        string consoleString;
        SymbolsSelector selector = new SymbolsSelector();

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
            answer = selector.MaximumIdenticalSymbols(consoleString);
            Console.Write("Maximum number of identical consecutive symbols: ");
            Console.Write(answer);
        }
    }
}
