using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// Class for definition of bus
    /// </summary>
    public class Bus : Vehicle
    {
        private int _passengersCount;
        private const int _MIN_PASSENGERS_COUNT = 0;
        private const int _MAX_PASSENGERS_COUNT = 300;
        private const string _vehicleType = "Bus";

        /// <summary>
        /// Constructor for Bus
        /// </summary>
        /// <param Passengers count = "passengersCount"></param>
        /// <param Engine = "engine"></param>
        /// <param Chassis = "chassis"></param>
        /// <param Transmission = "transmission"></param>
        public Bus(int passengersCount, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            PassengersCount = passengersCount;
        }

        public int PassengersCount
        {
            get
            {
                return _passengersCount;
            }
            set
            {
                BusPassengersCountCheckValue(value);
                _passengersCount = value;
            }
        }

        /// <summary>
        /// Method for checking passengers count
        /// </summary>
        /// <param Passengers count = "value"></param>
        /// <returns>Passengers count</returns>
        private int BusPassengersCountCheckValue(int value)
        {
            if (value < _MIN_PASSENGERS_COUNT || value > _MAX_PASSENGERS_COUNT)
            {
                throw new ArgumentException("Bus passengers count must be bigger than " + _MIN_PASSENGERS_COUNT + " and less than " + _MAX_PASSENGERS_COUNT);
            }
            return value;
        }
        /// <summary>
        /// Method for getting infromation about Bus
        /// </summary>
        /// <returns>Infromation about Bus as a string</returns>
        new public string GetInfo()
        {
            return base.GetInfo() + "Passengers count: " + _passengersCount + "\n";
        }
    }
}