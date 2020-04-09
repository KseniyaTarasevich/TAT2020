using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace task_DEV1_5
{
    /// <summary>
    /// Class that defines Autopark
    /// </summary>
    public class Autopark
    {
        static Autopark instance;
        static XDocument xmlDocument;

        /// <summary>
        /// Constructor for Autopark
        /// </summary>
        public Autopark()
        {
            xmlDocument = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("Cars"));

        }
        /// <summary>
        /// Method that addes list of cars to XML-file
        /// </summary>
        public void AddCar()
        {
            foreach (var item in Car.GetAllCars())
            {
                xmlDocument.Root.Add(new XElement("Car", new XElement("Brand", item.Brand),
                    new XElement("Model", item.Model),
                    new XElement("Quantity", item.Quantity),
                    new XElement("OneUnitCost", item.OneUnitCost)));
            }
            xmlDocument.Save(Path.Combine(Environment.CurrentDirectory, "Autopark.xml"));
        }

        public static Autopark GetInstance()
        {
            if (instance == null)
            {
                instance = new Autopark();
            }

            return instance;
        }

        /// <summary>
        /// Method that count all cars
        /// </summary>
        public void CountAll()
        {

            int carCount = 0;
            foreach (var car in XDocument.Load(Path.Combine(Environment.CurrentDirectory, "Autopark.xml")).Descendants("Car"))
            {
                carCount += (int)car.Element("Quantity");
            }

          //  Console.WriteLine("Count of all cars: " + carCount);
        }


        /// <summary>
        /// Method that count average price of all cars
        /// </summary>
        public void AveragePrice()
        {

            double carAveragePrice = 0;

            int carCount = 0;
            foreach (var car in XDocument.Load(Path.Combine(Environment.CurrentDirectory, "Autopark.xml")).Descendants("Car"))
            {
                carCount += (int)car.Element("Quantity");
                carAveragePrice += (double)car.Element("OneUnitCost");
            }

            carAveragePrice /= carCount;
            Console.WriteLine("Average price of all cars: " + carAveragePrice + " dollars");
        }


        /// <summary>
        /// Method that count average cars price of the concrete brand
        /// </summary>
        /// <param Brand of the car = "carBrand"></param>
        public void AveragePriceType(string carBrand)
        {
            double carAveragePrice = 0;
            int carCount = 0;

            foreach (var car in XDocument.Load(Path.Combine(Environment.CurrentDirectory, "Autopark.xml")).Descendants("Car"))
            {
                if (car.Element("Brand").Value == carBrand)
                {
                    carCount += (int)car.Element("Quantity");
                    carAveragePrice += (double)car.Element("OneUnitCost");
                }
            }

            carAveragePrice /= carCount;
            Console.WriteLine("Average price of cars " + carBrand + " brand: " + carAveragePrice);
        }

        /// <summary>
        /// Method that count different brands of the cars 
        /// </summary>
        public void CountTypes()
        {

            List<string> brands = new List<string>();
            foreach (XElement car in XDocument.Load(Path.Combine(Environment.CurrentDirectory, "Autopark.xml")).Descendants("Car"))
            {
                brands.Add(car.Element("Brand").Value);
            }
            Console.WriteLine("Count of brands: " + brands.Distinct().Count().ToString());
        }
    }
}

