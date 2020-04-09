namespace task_DEV1_5
{
    /// <summary>
    /// Class that defines command for calculating average price cars of the same brand
    /// </summary>
    class AveragePriceTypeCommand : ICommand
    {
        public string Brand { get; private set; }

        public AveragePriceTypeCommand(string brand)
        {
          Brand = brand;
        }

        /// <summary>
        /// Method that executes command for calculating average price cars of the same brand
        /// </summary>
        public void Execute()
        {
            Autopark.GetInstance().AveragePriceType(Brand);
        }
    }
}