using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskDev1;

namespace TaskDEV1TestProject
{
    [TestClass]
    public class TestTaskDEV1
    {
        [DataTestMethod]
        [DataRow("aaa", 3)]
        [DataRow("", 0)]
        [DataRow("a", 1)]
        [DataRow("asdfggghjk", 3)]
        [DataRow("asdfghjkkkkk", 5)]
        [DataRow("aaaasdfghjk", 4)]
        [DataRow("asdfghjk", 1)]
        [DataRow("aaaddd", 3)]
        [DataRow("aaafhkddddkj", 4)]
        [DataRow("gdhhhakaaaa", 4)]
        [DataRow("gggggdhhhakaa", 5)]
        [DataRow("gggggdhakaaaa", 5)]
        [DataRow("'\u00a7'", 1)]
        [DataRow("\t", 1)]
        [DataRow("abababab", 1)]
        public void DifferentSequences(string example, int expected)
        {
            SymbolsSelector selector = new SymbolsSelector();
            int actual = selector.MaximumIdenticalSymbols(example);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullExeption()
        {
            SymbolsSelector selector = new SymbolsSelector();
            selector.MaximumIdenticalSymbols(null);
        }
    }
}
