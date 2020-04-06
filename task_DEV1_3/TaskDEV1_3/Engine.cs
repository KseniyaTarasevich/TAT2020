using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// Class for definition of Engine
    /// </summary>
    public class Engine
    {
        private float _enginePower;
        private float _engineVolume;
        private string _engineType;
        private string _engineSerialNumber;
        private const float _MIN_ENGINE_POWER = 0.1f;
        private const float _MAX_ENGINE_POWER = 500;
        private const float _MIN_ENGINE_VOLUME = 10;
        private const float _MAX_ENGINE_VOLUME = 15000;

        /// <summary>
        /// Constructor for Engine
        /// </summary>
        /// <param Power = "power"></param>
        /// <param Volume = "volume"></param>
        /// <param Engine type = "type"></param>
        /// <param Engine serial number = "serialNumber"></param>
        public Engine(float power, float volume, string type, string serialNumber)
        {
            EnginePower = power;
            EngineVolume = volume;
            EngineType = type;
            EngineSerialNumber = serialNumber;
        }
        public float EnginePower
        {
            get
            {
                return _enginePower;
            }
            set
            {
                EnginePowerCheckValue(value);
                _enginePower = value;
            }
        }

        public float EngineVolume
        {
            get
            {
                return _engineVolume;
            }
            set
            {
                EngineVolumeCheckValue(value);
                _engineVolume = value;
            }
        }

        public string EngineType
        {
            get
            {
                return _engineType;
            }
            set
            {
                EngineTypeCheckValueNullOrEmpty(value);
                EngineTypeCheckValueDigitsOrLetters(value);
                _engineType = value;
            }
        }

        public string EngineSerialNumber
        {
            get
            {
                return _engineSerialNumber;
            }
            set
            {
                EngineSerialNumberCheckValueNullOrEmpty(value);
                EngineSerialNumberCheckValueDigitsOrLetters(value);
                _engineSerialNumber = value;
            }
        }

        /// <summary>
        /// Method for checking engine power
        /// </summary>
        /// <param Engine power = "value"></param>
        /// <returns>Engine power</returns>
        private float EnginePowerCheckValue(float value)
        {
            if (value < _MIN_ENGINE_POWER || value > _MAX_ENGINE_POWER)
            {
                throw new ArgumentException("Engine power must be bigger than " + _MIN_ENGINE_POWER + " and less than " + _MAX_ENGINE_POWER);
            }
            return value;
        }

        /// <summary>
        /// Method for checking engine volume
        /// </summary>
        /// <param Engine volume = "value"></param>
        /// <returns>Engine volume</returns>
        private float EngineVolumeCheckValue(float value)
        {
            if (value < _MIN_ENGINE_VOLUME || value > _MAX_ENGINE_VOLUME)
            {
                throw new ArgumentException("Engine power must be bigger than " + _MIN_ENGINE_VOLUME + " and less than " + _MAX_ENGINE_VOLUME);
            }
            return value;
        }

        /// <summary>
        ///  Method for checking engine type is NULL or empty
        /// </summary>
        /// <param Engine type="value"></param>
        /// <returns>Engine type</returns>
        private string EngineTypeCheckValueNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Engine type can't be NULL or Empty");
            }
            return value;
        }

        /// <summary>
        ///  Method for checking serial number is NULL or empty
        /// </summary>
        /// <param Serial number = "value"></param>
        /// <returns>Serial number</returns>
        private string EngineSerialNumberCheckValueNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Engine serial number can't be NULL or Empty");
            }
            return value;
        }

        /// <summary>
        /// Method for checking engine type for digits and letters
        /// </summary>
        /// <param Engine type = "value"></param>
        /// <returns>Engine type</returns>
        private string EngineTypeCheckValueDigitsOrLetters(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    throw new ArgumentException("Engine type must contain only digits and letters");
                }
            }
            return value;
        }

        /// <summary>
        /// Method for checking serial number for digits and letters
        /// </summary>
        /// <param Serial number = "value"></param>
        /// <returns>Serial number</returns>
        private string EngineSerialNumberCheckValueDigitsOrLetters(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    throw new ArgumentException("Engine serial number must contains only digits and letters");
                }
            }
            return value;
        }

        /// <summary>
        /// Method for getting infromation about Engine
        /// </summary>
        /// <returns>Information about Engine as a string</returns>
        public string GetInfo()
        {
            return "\n\tInformation about Engine: \n\nPower: " + EnginePower + " watt\nVolume: " + EngineVolume
                + " cubic centimeter\nType: " + EngineType + "\nSerial number: " + EngineSerialNumber + "\n";
        }
    }
}