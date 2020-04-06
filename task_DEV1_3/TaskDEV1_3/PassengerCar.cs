using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// Class for definition of passenger car
    /// </summary>
    public class PassengerCar : Vehicle
    {
        private string _carBrand;
        private int _seatsNumber;
        private const string _vehicleType = "Passenger Car";
        private const int _MIN_SEATS_NUMBER = 2;
        private const int _MAX_SEATS_NUMBER = 4;

        /// <summary>
        /// Constructor for PassengerCar
        /// </summary>
        /// <param Number of seats = "seatsNumber"></param>
        /// <param Car brand = "carBrand"></param>
        /// <param Engine = "engine"></param>
        /// <param Chassis = "chassis"></param>
        /// <param Transmission = "transmission"></param>
        public PassengerCar(int seatsNumber, string carBrand, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            CarBrand = carBrand;
            SeatsNumber = seatsNumber;
        }
        public int SeatsNumber
        {
            get
            {
                return _seatsNumber;
            }
            set
            {
                CarSeatsNumberCheckValue(value);
                _seatsNumber = value;
            }
        }

        /// <summary>
        /// Method for checking number of seats
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Number of seats</returns>
        private int CarSeatsNumberCheckValue(int value)
        {
            if (value < _MIN_SEATS_NUMBER || value > _MAX_SEATS_NUMBER)
            {
                throw new ArgumentException("Seats must be bigger than " + _MIN_SEATS_NUMBER + " and less than " + _MAX_SEATS_NUMBER);
            }
            return value;
        }

        public string CarBrand
        {
            get
            {
                return _carBrand;
            }
            set
            {
                CarBrandCheckValueNullOrEmpty(value);
                CarBrandCheckValueDigitsOrLetters(value);
                _carBrand = value;
            }
        }

        /// <summary>
        /// Method for checking car brand is NULL or empty
        /// </summary>
        /// <param Car brand = "value"></param>
        /// <returns>Car brand</returns>
        private string CarBrandCheckValueNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Car brand can't be NULL or Empty");
            }
            return value;
        }

        /// <summary>
        /// Method for checking car brand for digits and letters
        /// </summary>
        /// <param Car brand = "value"></param>
        /// <returns>Car brand</returns>
        private string CarBrandCheckValueDigitsOrLetters(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    throw new ArgumentException("Car brand must contains only digits and letters");
                }
            }
            return value;
        }

        /// <summary>
        /// Method for getting infromation about PassengerCar
        /// </summary>
        /// <returns>Information about PassengerCar as a string</returns>
        new public string GetInfo()
        {
            return base.GetInfo() + "Number of seats: " + _seatsNumber + "\nBrand: " + _carBrand + "\n";
        }
    }
}