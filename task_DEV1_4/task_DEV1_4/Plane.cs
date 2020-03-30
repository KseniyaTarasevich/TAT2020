using System;

namespace task_DEV1_4
{
    /// <summary>
    /// 
    /// </summary>
    class Plane : IFlyable
    {
        private float _startPlaneVelocity = 200;
        private const int _MAX_PLANE_VELOCITY = 8500;

        Coordinate CurrentCoordinate = new Coordinate();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="planeCoordinate"></param>
        /// <param name="planeVelocity"></param>
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
       /// <param name="currentCoordinate"></param>
       /// <param name="newCoordinate"></param>
       /// <returns></returns>
       public float GetFlyTime(Coordinate currentCoordinate, Coordinate newCoordinate)
        {
            float flyingTime = 0;

            var distance = CurrentCoordinate.GetDistanceBetweenPoints(CurrentCoordinate, newCoordinate);

            if (Velocity > _MAX_PLANE_VELOCITY)
            {
                throw new ArgumentException("Plane Velocity can't be more than " + _MAX_PLANE_VELOCITY);
            }

            if (Velocity + distance > _MAX_PLANE_VELOCITY)
            {
                return flyingTime = distance / _MAX_PLANE_VELOCITY;
            }
            return flyingTime = distance / (Velocity + distance);
        }
    }
}