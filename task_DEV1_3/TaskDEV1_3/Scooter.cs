using System;

namespace TaskDEV1_3
{
    public class Scooter : Vehicle
    {
        private string _scooterColor;
        private const string _vehicleType = "Scooter";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scooterColor"></param>
        /// <param name="engine"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
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
       /// 
       /// </summary>
       /// <param name="value"></param>
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
       /// 
       /// </summary>
       /// <param name="value"></param>
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
        /// 
        /// </summary>
        /// <returns></returns>
        new public string GetInfo()
        {
            return base.GetInfo() + "Scooter color: " + _scooterColor + "\n";
        }

    }
}
