
namespace TaskDev1
{
    /// <summary>
    /// Class for calculating maximum number of identical consecutive symbols
    /// </summary>
    public class SymbolsSelector
    {
        /// <summary>
        /// Calculates number of identical consecutive symbols
        /// </summary>
        /// <param Input string = "consoleString"></param>
        /// <returns>Maximum number of identical consecutive symbols</returns>
        public int MaximumIdenticalSymbols(string consoleString)
        {
            int maxCount = 1;
            int currentCount = 1;

            if (consoleString.Length <= 1)
            {
                return consoleString.Length;
            }

            for (int i = 1; i < consoleString.Length; i++)
            {
                if (consoleString[i] == consoleString[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }

                    currentCount = 1;
                }
            }

            if (maxCount > currentCount)
            {
                return maxCount;
            }

            else return currentCount;
        }
    }
}
