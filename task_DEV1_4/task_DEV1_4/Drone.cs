using System;

namespace task_DEV1_4
{

    /// <summary>
    /// 
    /// </summary>
    class Drone : IFlyable
    {
        Coordinate CurrentCoordinate = new Coordinate();

        private const int _MAX_DRONE_DISTANCE = 1000;
        private float _droneVelocity = 1;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="droneCoordinate"></param>
        /// <param name="droneVelocity"></param>
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
        /// 
        /// </summary>
        /// <param name="newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            CurrentCoordinate = newCoordinate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CurrentCoordinate"></param>
        /// <param name="newCoordinate"></param>
        /// <returns></returns>
        public float GetFlyTime(Coordinate CurrentCoordinate, Coordinate newCoordinate)
        {
            float droneTime = 0;
            float droneFlyingTime = 0;
            var distance = CurrentCoordinate.GetDistanceBetweenPoints(CurrentCoordinate, newCoordinate);
            if (distance <= _MAX_DRONE_DISTANCE)
            {
                droneTime = 60 * (distance / Velocity);
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
