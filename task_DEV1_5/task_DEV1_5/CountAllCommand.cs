namespace task_DEV1_5
{
    /// <summary>
    /// Class that defines command for calculating count of cars
    /// </summary>
    class CountAllCommand : ICommand
    {
        /// <summary>
        /// Method that executes command for calculating count of cars
        /// </summary>
        public void Execute()
        {
            Autopark.GetInstance().CountAll();
        }
    }
}


