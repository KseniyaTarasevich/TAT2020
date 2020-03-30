using System;

namespace task_DEV1_4
{
    /// <summary>
    /// 
    /// </summary>
    public struct Coordinate
    {
        private float _x;
        private float _y;
        private float _z;


        public float X
        {
            get
            {
                return _x; ;
            }
            set
            {
                CheckCoordinateValue(value);
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                CheckCoordinateValue(value);
                _y = value;
            }
        }

        public float Z
        {
            get
            {
                return _z;
            }
            set
            {
                CheckCoordinateValue(value);
                _z = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Coordinate(float x, float y, float z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public float CheckCoordinateValue(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("All coodinates components must be positive");
            }
            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentCoordinate"></param>
        /// <param name="newCoordinate"></param>
        /// <returns></returns>
        public float GetDistanceBetweenPoints(Coordinate currentCoordinate, Coordinate newCoordinate)
        {
            return (float)(Math.Sqrt((X - newCoordinate.X) * (X - newCoordinate.X) +
                 (Y - newCoordinate.Y) * (Y - newCoordinate.Y) +
                 (Z - newCoordinate.Z) * (Z - newCoordinate.Z)));
        }
    }
}