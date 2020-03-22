using System;

namespace TaskDEV1_3
{
    /// <summary>
    /// 
    /// </summary>
    public class Transmission
    {
        private string _transmissionType;
        private int _transmissionGearsNumber;
        private string _transmissionManufacturer;
        private const int _MIN_GEARS_NUMBER = 0;
        private const int _MAX_GEARS_NUMBER = 10;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="gearsNumber"></param>
        /// <param name="manufacturer"></param>
        public Transmission(string type, int gearsNumber, string manufacturer)
        {
            TransmissionType = type;
            TransmissionGearsNumber = gearsNumber;
            TransmissionManufacturer = manufacturer;
        }

        public string TransmissionType
        {
            get
            {
                return _transmissionType;
            }
            set
            {
                TransmissionTypeCheckValueNullOrEmpty(value);
                TransmissionTypeCheckValueDigitsOrLetters(value);
                _transmissionType = value;
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
       private string TransmissionTypeCheckValueNullOrEmpty(string value)
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
        private string TransmissionTypeCheckValueDigitsOrLetters(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    throw new ArgumentException("Transmission type must contain only digits or letters");
                }
            }
            return value;
        }

        public int TransmissionGearsNumber
        {
            get
            {
                return _transmissionGearsNumber;
            }
            set
            {
                TransmissionGearsNumberCheckValue(value);
                _transmissionGearsNumber = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int TransmissionGearsNumberCheckValue(int value)
        {
            if (value < _MIN_GEARS_NUMBER || value > _MAX_GEARS_NUMBER)
            {
                throw new ArgumentException("Transmission number of gears Number must be bigger than " + _MIN_GEARS_NUMBER + " and less than " + _MAX_GEARS_NUMBER);
            }
            return value;
        }

        public string TransmissionManufacturer
        {
            get
            {
                return _transmissionManufacturer;
            }
            set
            {
                TransmissionManufacturerCheckValueNullOrEmpty(value);
                TransmissionManufacturerCheckValueDigitsOrLetters(value);
                _transmissionManufacturer = value;
            }
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
       private string TransmissionManufacturerCheckValueNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Transmission manufacturer can't be NULL or Empty");
            }
            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string TransmissionManufacturerCheckValueDigitsOrLetters(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    throw new ArgumentException("Transmission manufacturer must contain only digits or letters");
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
            return "\n\tInformation about Transmission: \n\nType: " + TransmissionType + "\nNumber of Gears: " + TransmissionGearsNumber
                + "\nManufacturer: " + TransmissionManufacturer + "\n";
        }
    }
}
