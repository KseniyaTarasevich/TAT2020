using System;

namespace TaskDEV1_3
{
    public class Bus : Vehicle
    {
        private int _passengersCount;
        private const int _MIN_PASSENGERS_COUNT = 0;
        private const int _MAX_PASSENGERS_COUNT = 300;
        private const string _vehicleType = "Bus";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="passengersCount"></param>
        /// <param name="engine"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        public Bus(float passengersCount, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            passengersCount = _passengersCount;
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
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int BusPassengersCountCheckValue(int value)
        {
            if (value < _MIN_PASSENGERS_COUNT || value > _MAX_PASSENGERS_COUNT)
            {
                throw new ArgumentException("Bus passengers count must be bigger than " + _MIN_PASSENGERS_COUNT + " and less than " + _MAX_PASSENGERS_COUNT);
            }
            return value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        new public string GetInfo()
        {
            return base.GetInfo() + "Passengers count: " + _passengersCount + "\n";
        }

    }
}
