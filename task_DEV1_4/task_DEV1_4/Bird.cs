using System;

namespace task_DEV1_4
{
    /// <summary>
    /// Class for definition of the Bird
    /// </summary>
    public class Bird : IFlyable
    {
        private const int _MIN_BIRD_VELOCITY = 0;
        private const int _MAX_BIRD_VELOCITY = 20;
        private int _velocity;
        Coordinate currentCoordinate = new Coordinate();

        /// <summary>
        /// Constructor for Bird
        /// </summary>
        /// <param Bird coordinate = "birdCoordinate"></param>
        public Bird(Coordinate birdCoordinate)
        {
            Velocity = new Random().Next(_MIN_BIRD_VELOCITY, _MAX_BIRD_VELOCITY);
        }

        public int Velocity
        {
            get
            {
                return _velocity;
            }

            set
            {
                _velocity = value;
            }
        }

        /// <summary>
        /// Method for flying to another coordinate
        /// </summary>
        /// <param New coordinate of the bird = "newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            currentCoordinate = newCoordinate;
        }

        /// <summary>
        /// Method for getting flight time
        /// </summary>
        /// <param Current coordinate of the bird = "currentCoordinate"></param>
        /// <param New coordinate of the bird = "newCoordinate"></param>
        /// <returns>Flight time</returns>
        public int GetFlyTime(Coordinate currentCoordinate, Coordinate newCoordinate)
        {
            var distance = currentCoordinate.GetDistanceBetweenPoints(currentCoordinate, newCoordinate);

            return ((int)(60 * distance) / Velocity);
        }
    }
}
