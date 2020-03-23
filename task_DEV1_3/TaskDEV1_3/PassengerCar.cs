using System;

namespace TaskDEV1_3
{
    public class PassengerCar : Vehicle
    {
        private string _carBrand;
        private int _seatsNumber;
        private const string _vehicleType = "Passenger Car";
        private const int _MIN_SEATS_NUMBER = 2;
        private const int _MAX_SEATS_NUMBER = 4;

        public PassengerCar(int seatsNumber, string carBrand, Engine engine, Chassis chassis, Transmission transmission) : base (engine, chassis, transmission, _vehicleType)
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
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string CarBrandCheckValueNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Car brand can't be NULL or Empty");
            }
            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string CarBrandCheckValueDigitsOrLetters(string value)
        {
            foreach(char c in value)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    throw new ArgumentException("Car brand must contains only digits and letters");
                }
            }
            return value;
        }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       new public string GetInfo()
        {
            return base.GetInfo() + "Number of seats: " + _seatsNumber + "\nBrand: " + _carBrand + "\n";
        }

    }
}

