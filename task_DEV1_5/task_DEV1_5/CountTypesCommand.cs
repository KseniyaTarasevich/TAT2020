namespace task_DEV1_5
{
    /// <summary>
    /// Class that defines command for calculating count of car types
    /// </summary>
    class CountTypesCommand : ICommand
    {
        /// <summary>
        /// Method that executes command for calculating count of car types
        /// </summary>
        public void Execute()
        {
            Autopark.GetInstance().CountTypes();
        }
    }
}