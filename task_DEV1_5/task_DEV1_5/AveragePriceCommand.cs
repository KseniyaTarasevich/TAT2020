namespace task_DEV1_5
{
    /// <summary>
    /// Class that defines command for calculating average price
    /// </summary>
    class AveragePriceCommand : ICommand
    {
        /// <summary>
        /// Method that executes command for calculating average price
        /// </summary>
        public void Execute()
        {
            Autopark.GetInstance().AveragePrice();
        }
    }
}