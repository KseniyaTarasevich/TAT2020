using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV1_4;

namespace TaskDEV1_4TestProject
{
    [TestClass]
    public class UnitTestTaskDEV1_4
    {
        [DataTestMethod]
        [DataRow(0, 0, 0, 0, 0, 0, 0)]
        [DataRow(5, 0, 0, 2, 0, 0, 3)]
        public void TestDestination(float x1, float y1, float z1, float x2, float y2, float z2, float expected)
        {
            Coordinate coordinate1 = new Coordinate(x1, y1, z1);
            Coordinate coordinate2 = new Coordinate(x2, y2, z2);
            float actual = coordinate1.GetDistanceBetweenPoints(coordinate1, coordinate2);
            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]

        [DataRow(-9, 2, 3)]
        [DataRow(9, -2, 3)]
        [DataRow(9, 2, -3)]
        [DataRow(-9, -2, 3)]
        [DataRow(-9, 2, -3)]
        [DataRow(9, -2, -3)]
        [DataRow(-9, -2, -3)]
        public void TestCoordinates(float x, float y, float z)
        {
            new Coordinate(x, y, z);
        }

        [DataTestMethod]
        [DataRow(1, 1, 0, 4, 5, 0, 330)]
        public void TestDroneFlyTime(float x1, float y1, float z1, float x2, float y2, float z2, float expected)
        {
            Coordinate coordinate1 = new Coordinate(x1, y1, z1);
            Coordinate coordinate2 = new Coordinate(x2, y2, z2);
            Drone drone = new Drone(coordinate1, 1);
            float actual = drone.GetFlyTime(coordinate1, coordinate2);
            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [DataRow(1, 1, 0, 4, 5, 0, 51)]
        public void TestPlaneFlyTime(float x1, float y1, float z1, float x2, float y2, float z2, float expected)
        {
            Coordinate coordinate1 = new Coordinate(x1, y1, z1);
            Coordinate coordinate2 = new Coordinate(x2, y2, z2);
            Plane plane = new Plane(coordinate1, 1);
            float actual = plane.GetFlyTime(coordinate1, coordinate2);
            Assert.AreEqual(actual, expected);
        }
    }
}