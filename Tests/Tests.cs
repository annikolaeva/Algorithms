using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp3.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FirstTest()
        {
            int[] a = { 1, 2, 3 };
            int sum = Tasks.GetSumPositiveNumbers(a);
            Assert.AreEqual(7,sum);
        }

        public void SecondTest()
        {
            int[] a = { 2, 3, 4 };
            int sum = Tasks.GetSumNumbers(a);
            Assert.AreEqual(9, sum);
        }
    }
}
