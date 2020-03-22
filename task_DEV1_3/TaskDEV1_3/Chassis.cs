using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// 
    /// </summary>
    public class Chassis
    {
        private int _chassisWheelNumber;
        private int _chassisCount;
        private float _chassisPermissibleLoad;
        private const int _MIN_CHASSIS_COUNT = 2;
        private const int _MAX_CHASSIS_COUNT = 20;
        private const float _MIN__CHASSIS_PERMISSIBLE_LOAD = 0;
        private const float _MAX__CHASSIS_PERMISSIBLE_LOAD = 150000;
        private const int _MIN_WHEEL_NUMBER = 1;
        private const int _MAX_WHEEL_NUMBER = 20;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="wheelNumber"></param>
        /// <param name="count"></param>
        /// <param name="permissibleLoad"></param>
        public Chassis(int wheelNumber, int count, float permissibleLoad)
        {
            ChassisWheelNumber = wheelNumber;
            ChassisCount = count;
            ChassisPermissibleLoad = permissibleLoad;
        }

        public int ChassisWheelNumber
        {
            get
            {
                return _chassisWheelNumber;
            }
            set
            {
                ChassisWheelNumberCheckValue(value);
                _chassisWheelNumber = value;
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
       private int ChassisWheelNumberCheckValue(int value)
        {
            if (value < _MIN_WHEEL_NUMBER || value > _MAX_WHEEL_NUMBER)
            {
                throw new ArgumentException("Chassis wheel №" + value + " doesn't exist");
            }
            return value;
        }

        public int ChassisCount
        {
            get
            {
                return _chassisCount;
            }

            set
            {
                ChassisCountCheckValue(value);
                _chassisCount = value;
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
       private int ChassisCountCheckValue(int value)
        {
            if (value < _MIN_CHASSIS_COUNT || value > _MAX_CHASSIS_COUNT)
            {
                throw new ArgumentException("Chassis count must be bigger than " + _MIN_CHASSIS_COUNT + " and less than " + _MAX_CHASSIS_COUNT);
            }
            return value;
        }

        public float ChassisPermissibleLoad
        {
            get
            {
                return _chassisPermissibleLoad;
            }

            set
            {
                ChassisPermissibleLoadCheckValue(value);
                _chassisPermissibleLoad = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private float ChassisPermissibleLoadCheckValue(float value)
        {
            if (value < _MIN__CHASSIS_PERMISSIBLE_LOAD || value > _MAX__CHASSIS_PERMISSIBLE_LOAD)
            {
                throw new ArgumentException("Chassis permissible load must be bigger than " + _MIN__CHASSIS_PERMISSIBLE_LOAD + " and less than " + _MAX__CHASSIS_PERMISSIBLE_LOAD);
            }
            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return "\n\tInformation about Chassis: \n\nWheel Number: " + ChassisWheelNumber + "\nCount: " + ChassisCount
                + "\nPermissible load: " + ChassisPermissibleLoad + "\n";
        }
    }
}
