using System;

namespace task_DEV1_4
{
    /// <summary>
    /// Class for definition of the Plane
    /// </summary>
    public class Plane : IFlyable
    {
        private float _startPlaneVelocity = 200;
        private const int _MAX_PLANE_VELOCITY = 8500;

        Coordinate CurrentCoordinate = new Coordinate();

        /// <summary>
        /// Constructor for Plane
        /// </summary>
        /// <param Coordinate of the plane = "planeCoordinate"></param>
        /// <param New coordinate of the plane = "planeVelocity"></param>
        public Plane(Coordinate planeCoordinate, float planeVelocity)
        {
            Velocity = planeVelocity;
        }
        public float Velocity
        {
            get
            {
                return _startPlaneVelocity;
            }

            set
            {
                _startPlaneVelocity = value;
            }
        }

        /// <summary>
        /// Method for flying to another coordinate
        /// </summary>
        /// <param New coordinate of the plane = "newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            CurrentCoordinate = newCoordinate;
        }

        /// <summary>
        /// Method for getting flight time
        /// </summary>
        /// <param Current coordinate of the plane = "currentCoordinate"></param>
        /// <param New coordinate of the plane = "newCoordinate"></param>
        /// <returns>Flight time</returns>
        public int GetFlyTime(Coordinate currentCoordinate, Coordinate newCoordinate)
        {
            int flightTime = 0;

            var distance = CurrentCoordinate.GetDistanceBetweenPoints(CurrentCoordinate, newCoordinate);

            if (Velocity > _MAX_PLANE_VELOCITY)
            {
                throw new ArgumentException("Plane Velocity can't be more than " + _MAX_PLANE_VELOCITY);
            }

            if (Velocity + distance > _MAX_PLANE_VELOCITY)
            {
                return flightTime = (int) (distance / _MAX_PLANE_VELOCITY);
            }
            return flightTime = (int) (60 * (distance / (Velocity + distance)));
        }
    }
} 