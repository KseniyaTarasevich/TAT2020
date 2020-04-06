using System;

namespace task_DEV1_4
{

    /// <summary>
    /// Class for definition of the Drone
    /// </summary>
   public class Drone : IFlyable
    {
        Coordinate CurrentCoordinate = new Coordinate();

        private const int _MAX_DRONE_DISTANCE = 1000;
        private float _droneVelocity = 1;

        /// <summary>
        /// Constructor for Drone
        /// </summary>
        /// <param Coordinate of the drone = "droneCoordinate"></param>
        /// <param Velocity of the drone = "droneVelocity"></param>
        public Drone(Coordinate droneCoordinate, float droneVelocity)
        {
            Velocity = droneVelocity;
        }

        public float Velocity
        {
            get
            {
                return _droneVelocity;
            }

            set
            {
                _droneVelocity = value;
            }
        }

        /// <summary>
        /// Method for flying to another coordinate
        /// </summary>
        /// <param New coordinate of the drone = "newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            CurrentCoordinate = newCoordinate;
        }

        /// <summary>
        /// Method for getting flight time
        /// </summary>
        /// <param Current coordinate of the drone = "CurrentCoordinate"></param>
        /// <param New coordinate of the drone = "newCoordinate"></param>
        /// <returns>Flight time</returns>
        public int GetFlyTime(Coordinate CurrentCoordinate, Coordinate newCoordinate)
        {
            int droneTime = 0;
            int droneFlyingTime = 0;
            var distance = CurrentCoordinate.GetDistanceBetweenPoints(CurrentCoordinate, newCoordinate);
            if (distance <= _MAX_DRONE_DISTANCE)
            {
                droneTime = (int)(60 * (distance / Velocity));
                droneFlyingTime += droneTime + droneTime / 10;
            }
            else
            {
                throw new ArgumentException("Drone can't fly more than " + _MAX_DRONE_DISTANCE);
            }

            return droneFlyingTime;
        }
    }
}
