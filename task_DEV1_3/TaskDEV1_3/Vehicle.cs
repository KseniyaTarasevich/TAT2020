using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// Class for definition of vehicle
    /// </summary>
    public abstract class Vehicle
    {
        Engine _engine;
        Chassis _chassis;
        Transmission _transmission;

        private string _vehicleType;

        /// <summary>
        /// Constructor for Vehicle
        /// </summary>
        /// <param Engine = "engine"></param>
        /// <param Chassis = "chassis"></param>
        /// <param Transmission = "transmission"></param>
        /// <param Type of the vehicle = "vehicleType"></param>
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
                VehicleTypeCheckValueDigitsOrLetters(value);
                _vehicleType = value; ;
            }
        }

        /// <summary>
        /// Method for checking type of the vehicle is NULL or empty
        /// </summary>
        /// <param Type of the vehicle="value"></param>
        /// <returns>Type of the vehicle</returns>
        private string VehicleTypeCheckNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Vehicle type can't be NULL or Empty");
            }
            return value;
        }

        /// <summary>
        /// Method for checking type of the vehicle for digits and letters
        /// </summary>
        /// <param Type of the vehicle="value"></param>
        /// <returns>Type of the vehicle</returns>
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
        /// Method for getting infromation about Vehicle
        /// </summary>
        /// <returns>Infromation about Vehicle as a string</returns>
        public string GetInfo()
        {
            return "\n\tVehicle Type: " + _vehicleType + "\n" + _engine.GetInfo() + _chassis.GetInfo() + _transmission.GetInfo();
        }
    }
}