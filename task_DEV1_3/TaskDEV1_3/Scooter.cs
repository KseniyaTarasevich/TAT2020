using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// Class for definition of scooter
    /// </summary>
    public class Scooter : Vehicle
    {
        private string _scooterColor;
        private const string _vehicleType = "Scooter";

        /// <summary>
        /// Constructor for Scooter
        /// </summary>
        /// <param Scooter color = "scooterColor"></param>
        /// <param Engine = "engine"></param>
        /// <param Chassis = "chassis"></param>
        /// <param Transmission = "transmission"></param>
        public Scooter(string scooterColor, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            ScooterColor = scooterColor;
        }

        public string ScooterColor
        {
            get
            {
                return _scooterColor;
            }
            set
            {
                ScooterColorCheckValueNullOrEmpty(value);
                ScooterColorCheckValueDigitsOrLetters(value);
                _scooterColor = value;
            }
        }

        /// <summary>
        /// Method for checking scooter color is NULL or empty
        /// </summary>
        /// <param Scooter color = "value"></param>
        /// <returns></returns>
        private string ScooterColorCheckValueNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Transmission type can't be NULL or Empty");
            }
            return value;
        }

        /// <summary>
        /// Method for checking scooter color for digits and letters
        /// </summary>
        /// <param Scooter color = "value"></param>
        /// <returns></returns>
        private string ScooterColorCheckValueDigitsOrLetters(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetter(c))
                {
                    throw new ArgumentException("Scooter color must contain only letters");
                }
            }
            return value;
        }

        /// <summary>
        /// Method for getting infromation about Scooter
        /// </summary>
        /// <returns>Infromation about Scooter as a string</returns>
        new public string GetInfo()
        {
            return base.GetInfo() + "Scooter color: " + _scooterColor + "\n";
        }
    }
}