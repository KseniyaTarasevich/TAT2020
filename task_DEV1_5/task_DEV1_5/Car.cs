using System;
using System.Collections.Generic;

namespace task_DEV1_5
{
    /// <summary>
    /// Class that defines information about car
    /// </summary>
    public class Car
    {
        public string brand;
        public string model;
        public int quantity;
        public double oneUnitCost;

        private const int _MIN_CARS_QUANTITY = 1;
        private const double _MIN_ONE_UNIT_COST = 0;

        /// <summary>
        /// Constructor for Car
        /// </summary>
        /// <param Car brand = "brand"></param>
        /// <param Car model = "model"></param>
        /// <param Car quantity = "quantity"></param>
        /// <param Cost of one unit = "oneUnitCost"></param>
        public Car(string brand, string model, int quantity, double oneUnitCost)
        {
            Brand = brand;
            Model = model;
            Quantity = quantity;
            OneUnitCost = oneUnitCost;
        }


        public Car() { }


        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                CarBrandCheckValueNullOrEmpty(value);
                brand = value;
            }
        }

        /// <summary>
        /// Method for checking Car Brand is NULL or Empty,
        /// throws ArgumentException when CarBrand is Null or Empty 
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

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                CarModelCheckValueNullOrEmpty(value);
                model = value;
            }
        }

        /// <summary>
        /// Method for checking Car Model is NULL or Empty,
        /// throws ArgumentException when CarModel is Null or Empty 
        /// </summary>
        /// <param Car Model = "value"></param>
        /// <returns>Car model</returns>
        private string CarModelCheckValueNullOrEmpty(string value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("Car model can't be NULL or Empty");
            }
            return value;
        }


        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                CarQuantityCheckValue(value);
                quantity = value;
            }
        }

        /// <summary>
        /// Method for checking Cars Quantity is bigger than int.MaxValue
        /// or less than _MIN_CARS_QUANTITY
        /// If Quantity is bigger than int.MaxValue of less than _MIN_CARS_QUANTITY
        /// throws ArgumentException
        /// </summary>
        /// <param Cars quantity = "value"></param>
        /// <returns>Cars quantity</returns>
        private int CarQuantityCheckValue(int value)
        {
            if (value < _MIN_CARS_QUANTITY || value > int.MaxValue)
            {
                throw new ArgumentException("Car quantity can't be less than " + _MIN_CARS_QUANTITY + " or bigger than " + int.MaxValue);
            }
            return value;
        }

        public double OneUnitCost
        {
            get
            {
                return oneUnitCost;
            }

            set
            {
                CarOneUnitCostCheckValue(value);
                oneUnitCost = value;
            }
        }

        /// <summary>
        /// Method for checking Car OneUnitCost is bigger than double.MaxValue
        /// or less than _MIN_ONE_UNIT_COST
        /// If cost is bigger than double.MaxValue of less than _MIN_ONE_UNIT_COST
        /// throws ArgumentException
        /// </summary>
        /// <param Cars one unit cost = "value"></param>
        /// <returns>Cars one unit cost</returns>
        private double CarOneUnitCostCheckValue(double value)
        {
            if (value < _MIN_ONE_UNIT_COST || value > double.MaxValue)
            {
                throw new ArgumentException("Car one unit cost can't be less than " + _MIN_ONE_UNIT_COST + " or bigger than " + double.MaxValue);
            }
            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Car>  GetAllCars()
        {
            return new List<Car>   {

       new Car {Brand = "opel", Model = "B45", Quantity = 2, OneUnitCost=4500 },
       new Car {Brand ="audi",Model= "a90", Quantity =10, OneUnitCost=200},
       new Car{Brand ="geely", Model="astra", Quantity =1, OneUnitCost = 8900},
       new Car{Brand ="land rover", Model="landland", Quantity =1, OneUnitCost=41000}   };

        }
    }
}