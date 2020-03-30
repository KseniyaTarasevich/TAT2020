using System;

namespace task_DEV1_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Coordinate coordinate1 = new Coordinate(1, 1, 0);
                Coordinate coordinate2 = new Coordinate(4, 5, 0);
                Drone drone = new Drone(coordinate1, 1);
                Plane plane = new Plane(coordinate1, 200);
                Bird bird = new Bird(coordinate1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
