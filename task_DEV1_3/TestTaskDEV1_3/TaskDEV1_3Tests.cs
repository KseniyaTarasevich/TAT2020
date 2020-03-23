using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskDEV1_3;

namespace TestTaskDEV1_3
{
    [TestClass]
    public class TaskDEV1_3Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow("", 3, "Germany")]
        [DataRow("M1", 3, "")]
        [DataRow("M1", 3, null)]
        [DataRow(null, 3, "Germany")]
        [DataRow("M1", -1, "Germany")]
        [DataRow("M1", 11, "Germany")]
        [DataRow("M1", 1, "Germany_")]
        public void TestTransmissionExeption(string type, int gearsNumber, string manufacturer)
        {
            new Transmission(type, gearsNumber, manufacturer);
        }

        [TestMethod]
        [DataRow("M1", 0, "Germany")]
        [DataRow("M1", 10, "Germany")]
        [DataRow("M1", 5, "Germany")]
        public void TestTransmissionBorders(string type, int gearsNumber, string manufacturer)
        {
            new Transmission(type, gearsNumber, manufacturer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(0, 4, 5000)]
        [DataRow(0, -4, 5000)]
        [DataRow(0, 4, -5000)]
        public void TestChassisExeption(int wheelNumber, int count, float permissibleLoad)
        {
            new Chassis(wheelNumber, count, permissibleLoad);
        }

        [TestMethod]
        [DataRow(1, 4, 5000)]
        [DataRow(20, 4, 5000)]
        [DataRow(10, 4, 5000)]
        [DataRow(10, 2, 5000)]
        [DataRow(10, 20, 5000)]
        [DataRow(10, 4, 0)]
        [DataRow(10, 4, 150000)]
        public void TestChassisBorders(int wheelNumber, int count, float permissibleLoad)
        {
            new Chassis(wheelNumber, count, permissibleLoad);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(-10, 50, "P26", "ASD789H")]
        [DataRow(501, 50, "P26", "ASD789H")]
        [DataRow(10, -50, "P26", "ASD789H")]
        [DataRow(10, 150000, "P26", "ASD789H")]
        [DataRow(10, 50, "P_26", "ASD789H")]
        [DataRow(10, 50, "P26", "AS_D789H")]
        [DataRow(10, 50, null, "ASD789H")]
        [DataRow(10, 50, "P26", null)]
        [DataRow(10, 50, "", "ASD789H")]
        [DataRow(10, 50, "P26", "")]
        public void TestEngineExeption(float power, float volume, string type, string serialNumber)
        {
            new Engine(power, volume, type, serialNumber);
        }

        [TestMethod]
        [DataRow(0.1f, 50, "P26", "ASD789H")]
        [DataRow(500, 50, "P26", "ASD789H")]
        [DataRow(250, 50, "P26", "ASD789H")]
        [DataRow(250, 10, "P26", "ASD789H")]
        [DataRow(250, 15000, "P26", "ASD789H")]
        public void TestEngineBorders(float power, float volume, string type, string serialNumber)
        {
            new Engine(power, volume, type, serialNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(-10)]
        [DataRow(1000)]
        public void TestBusExpection(int passengerCount)
        {
            Engine engine = new Engine(250, 50, "P26", "ASD789H");
            Chassis chassis = new Chassis(10, 4, 5000);
            Transmission transmission = new Transmission("M1", 10, "Germany");
            new Bus(passengerCount, engine, chassis, transmission);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(-10, "Kia")]
        [DataRow(1000, "Kia")]
        [DataRow(3, "")]
        [DataRow(3, null)]
        [DataRow(3, "_Kia")]
        public void TestPassengerCarExpection(int seatsNumber, string carBrand)
        {
            Engine engine = new Engine(250, 50, "P26", "ASD789H");
            Chassis chassis = new Chassis(10, 4, 5000);
            Transmission transmission = new Transmission("M1", 10, "Germany");
            new PassengerCar(seatsNumber, carBrand, engine, chassis, transmission);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("_Black")]
        public void TestScooterExpection(string scooterColor)
        {
            Engine engine = new Engine(250, 50, "P26", "ASD789H");
            Chassis chassis = new Chassis(10, 4, 5000);
            Transmission transmission = new Transmission("M1", 10, "Germany");
            new Scooter(scooterColor, engine, chassis, transmission);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(-10)]
        [DataRow(1000000)]
        public void TestTruckExpection(float carryingCapacity)
        {
            Engine engine = new Engine(250, 50, "P26", "ASD789H");
            Chassis chassis = new Chassis(10, 4, 5000);
            Transmission transmission = new Transmission("M1", 10, "Germany");
            new Truck(carryingCapacity, engine, chassis, transmission);
        }
    }
}
