using System;

namespace task_DEV1_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Coordinate coordinate1 = new Coordinate(1, 1, 0);
            Coordinate coordinate2 = new Coordinate(4, 5, 0);
            Drone drone = new Drone(coordinate1, 1);
            Plane plane = new Plane(coordinate1, 200);
            Bird bird = new Bird(coordinate1);
            Console.WriteLine(drone.GetFlyTime(coordinate1, coordinate2));
            Console.WriteLine(plane.GetFlyTime(coordinate1, coordinate2));
            Console.WriteLine(bird.GetFlyTime(coordinate1, coordinate2));
            Console.WriteLine(coordinate1.GetDistanceBetweenPoints(coordinate1, coordinate2));

        }
    }
}
