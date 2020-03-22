using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Vehicle
    {
        Engine _engine;
        Chassis _chassis;
        Transmission _transmission;

        private string _vehicleType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        /// <param name="vehicleType"></param>
        public Vehicle(Engine engine, Chassis chassis, Transmission transmission, string vehicleType)
        {
            _engine = engine;
            _chassis = chassis;
            _transmission = transmission;
            _vehicleType = vehicleType;
        }

        public string VehicleType 
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                VehicleTypeCheckNullOrEmpty(value);
                _vehicleType = value; ;
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
       private string VehicleTypeCheckNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Vehicle type can't be NULL or Empty");
            }
            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string VehicleTypeCheckValueDigitsOrLetters(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    throw new ArgumentException("Vehicle type must contain only digits or letters");
                }
            }
            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return "\n\tVehicle Type: " + _vehicleType + "\n" + _engine.GetInfo() + _chassis.GetInfo() + _transmission.GetInfo() ;
        }
    }
}


