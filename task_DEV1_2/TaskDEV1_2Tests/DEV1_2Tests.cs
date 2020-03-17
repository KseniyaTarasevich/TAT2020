using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskDEV1_2;

namespace TaskDEV1_2Tests
{
    [TestClass]
    public class DEV1_2Tests
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        [DataRow(null, "2")]
        [DataRow("", "2")]
        [DataRow("aaa", "2")]
        [DataRow("88aaa", "2")]
        [DataRow("10", "aaa")]
        public void TestFormatException(string number, string numeralBase)
        {
            ConverterIntToAnotherNumeralSystem converter = new ConverterIntToAnotherNumeralSystem();
            converter.ConvertToAnotherNumeralSystem(number, numeralBase);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow("10", "1")]
        [DataRow("10", "21")]
        [DataRow("-10", "2")]
        [DataRow("10", "-2")]
        public void TestArgumentOutOfRangeException(string number, string numeralBase)
        {
            ConverterIntToAnotherNumeralSystem converter = new ConverterIntToAnotherNumeralSystem();
            converter.ConvertToAnotherNumeralSystem(number, numeralBase);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        [DataRow("2147483648", "2")]
        [DataRow("-2147483649", "2")]
        [DataRow("10", "2147483648")]
        [DataRow("10", "-2147483649")]
        public void TestOverflowException(string number, string numeralBase)
        {
            ConverterIntToAnotherNumeralSystem converter = new ConverterIntToAnotherNumeralSystem();
            converter.ConvertToAnotherNumeralSystem(number, numeralBase);
        }

        [DataTestMethod]
        [DataRow("0", "3", "0")]
        [DataRow("100", "2", "1100100")]
        [DataRow("100", "10", "100")]
        [DataRow("1000", "20", "2A0")]
        [DataRow("1000", "15", "46A")]
        [DataRow("191815", "20", "13JAF")]
        [DataRow("400", "17", "169")]
        public void DifferentNumbers(string number, string numeralBase, string expected)
        {
            ConverterIntToAnotherNumeralSystem converter = new ConverterIntToAnotherNumeralSystem();
            string actual = converter.ConvertToAnotherNumeralSystem(number, numeralBase);
            Assert.AreEqual(actual, expected);
        }
    }
}