using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// Class for defiition of truck
    /// </summary>
    public class Truck : Vehicle
    {
        private float _carryingCapacity;
        private const string _vehicleType = "Trunk";
        private const float _MIN_CARRYING_CAPACITY = 0;
        private const float _MAX_CARRYING_CAPACITY = 100000;

        /// <summary>
        /// Constructor for Truck
        /// </summary>
        /// <param Carrying capacity = "carryingCapacity"></param>
        /// <param Engine = "engine"></param>
        /// <param Chassis ="chassis"></param>
        /// <param Transmission = "transmission"></param>
        public Truck(float carryingCapacity, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            CarryingCapacity = carryingCapacity;
        }

        public float CarryingCapacity
        {
            get
            {
                return _carryingCapacity;
            }
            set
            {
                TruckCarryingCapacityCheckValue(value);
                _carryingCapacity = value;
            }
        }

        /// <summary>
        /// Method for checking carrying capacity
        /// </summary>
        /// <param Carrying capacity = "value"></param>
        /// <returns>Carrying capacity</returns>
        private float TruckCarryingCapacityCheckValue(float value)
        {
            if (value < _MIN_CARRYING_CAPACITY || value > _MAX_CARRYING_CAPACITY)
            {
                throw new ArgumentException("Truck carrying capacity must be bigger than " + _MIN_CARRYING_CAPACITY + " and less than " + _MAX_CARRYING_CAPACITY);
            }
            return value;
        }

        /// <summary>
        /// Method for getting infromation about Truck
        /// </summary>
        /// <returns>Infromation about Truck as a string</returns>
        new public string GetInfo()
        {
            return base.GetInfo() + "Carrying capacity" + _carryingCapacity + "\n";
        }
    }
}