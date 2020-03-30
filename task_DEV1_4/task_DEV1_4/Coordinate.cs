using System;

namespace task_DEV1_4
{
    /// <summary>
    /// Struct Coordinate
    /// </summary>
    public struct Coordinate
    {
        private float _x;
        private float _y;
        private float _z;

        /// <summary>
        /// Constructor for Coordinate
        /// </summary>
        /// <param x coordinate = "x"></param>
        /// <param y coordinate = "y"></param>
        /// <param z coordinate = "z"></param>
        public Coordinate(float x, float y, float z)
        {
            this._x = x;
            this._y = y;
            this._z = z;

            if (x < 0 || y < 0 || z < 0)
            {
                throw new ArgumentException("All coodinates components must be positive");
            }
        }

        public float X
        {
            get
            {
                return _x; ;
            }
            set
            {
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
                _z = value;
            }
        }

        /// <summary>
        /// Method for getting distance between two 3D coordinates
        /// </summary>
        /// <param Current coordinate = "currentCoordinate"></param>
        /// <param New coordinate = "newCoordinate"></param>
        /// <returns></returns>
        public float GetDistanceBetweenPoints(Coordinate currentCoordinate, Coordinate newCoordinate)
        {
            return (float)(Math.Sqrt((X - newCoordinate.X) * (X - newCoordinate.X) +
                 (Y - newCoordinate.Y) * (Y - newCoordinate.Y) +
                 (Z - newCoordinate.Z) * (Z - newCoordinate.Z)));
        }
    }
}