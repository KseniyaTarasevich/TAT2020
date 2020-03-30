using System;

namespace task_DEV1_4
{
    /// <summary>
    /// 
    /// </summary>
    class Bird : IFlyable
    {
        private const int _MIN_BIRD_VELOCITY = 0;
        private const int _MAX_BIRD_VELOCITY = 20;
        private float _velocity;
        Coordinate CurrentCoordinate = new Coordinate();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="birdCoordinate"></param>
        public Bird(Coordinate birdCoordinate)
        {
            Velocity = new Random().Next(_MIN_BIRD_VELOCITY, _MAX_BIRD_VELOCITY);
        }

        public float Velocity
        {
            get
            {
                return _velocity;
            }

            set
            {
                CheckBirdVelocity(value);
                _velocity = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float CheckBirdVelocity(float value)
        {
            if (value < _MIN_BIRD_VELOCITY || value > _MAX_BIRD_VELOCITY)
            {
                throw new ArgumentException("Birds can't fly with this velocity");
            }
            return value;
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
            var distance = CurrentCoordinate.GetDistanceBetweenPoints(CurrentCoordinate, newCoordinate);

            return distance / Velocity;
        }
    }
}
