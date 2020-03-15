using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskDev1_1;

namespace TaskDEV1_1TestProject
{
    [TestClass]
    public class TestTaskDEV1_1
    {
        [DataTestMethod]
        [DataRow("aaa", 1)]
        [DataRow("", 0)]
        [DataRow("a", 1)]
        [DataRow("asdfggghjk", 5)]
        [DataRow("asdfghjkkkkk", 8)]
        [DataRow("aaaasdfghjk", 8)]
        [DataRow("asdfghjk", 8)]
        [DataRow("aaaddd", 2)]
        [DataRow("aaafhkddddkj", 5)]
        [DataRow("gdhhhakaaaa", 4)]
        [DataRow("gggggdhhhakaa", 4)]
        [DataRow("gggggdhakaaaa", 6)]
        [DataRow("\u00a7\u00a7\u00a7\u00a4", 2)]
        [DataRow("\u00a7", 1)]
        [DataRow("\t", 1)]
        [DataRow("abababab", 8)]
        [DataRow("asd\t\thj", 4)]
        [DataRow("1234555", 5)]
        [DataRow("   asd", 4)]
        public void DifferentSequences(string example, int expected)
        {
            SymbolsSelector selector = new SymbolsSelector();
            int actual = selector.MaximumDifferentSymbols(example);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullExeption()
        {
            SymbolsSelector selector = new SymbolsSelector();
            selector.MaximumDifferentSymbols(null);
        }
    }
}
