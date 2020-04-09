using System;

namespace task_DEV1_5
{
    /// <summary>
    /// Class for working with console
    /// </summary>
    public class WorkWithConsole
    {
        private const string _AVERAGE_PRICE_COMMAND = "average price";
        private const string _AVERAGE_PRICE_TYPE_COMMAND = "average price type";
        private const string _COUNT_ALL_COMMAND = "count all";
        private const string _COUNT_TYPES_COMMAND = "count types";
        private const string _EXIT_COMMAND = "exit";

        /// <summary>
        /// Method for display commands and answers
        /// </summary>
        public void WorkingWithConsole()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Available commands:\n" + "count types\n" + "count all\n" + "average price\n" + "average price type\n" + "exit\n");

                string command = Console.ReadLine();

                switch (command)
                {

                    case _COUNT_ALL_COMMAND:
                        CountAllCommand countAll = new CountAllCommand();
                        countAll.Execute();
                        break;
                    case _COUNT_TYPES_COMMAND:
                        CountTypesCommand countTypes = new CountTypesCommand();
                        countTypes.Execute();
                        break;
                    case _AVERAGE_PRICE_COMMAND:
                        AveragePriceCommand averagePrice = new AveragePriceCommand();
                        averagePrice.Execute();
                        break;
                    case _AVERAGE_PRICE_TYPE_COMMAND:
                        string brand = GetCarBrand();
                        AveragePriceTypeCommand averagePriceType = new AveragePriceTypeCommand(brand);
                        averagePriceType.Execute();
                        break;
                    case _EXIT_COMMAND:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Such command doesn't exist. Try again");
                        break;
                }
            }
        }

        /// <summary>
        /// Method that gets car brand from console
        /// </summary>
        /// <returns>Car brand</returns>
        public static string GetCarBrand()
        {
            Console.WriteLine("Enter car brand");
            return Console.ReadLine();
        }
    }
}
