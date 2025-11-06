using System;
using Tyuiu.ReshetovaAA.Sprint2.Task3.V23.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double expected = Math.Round(x * Math.Pow((x + 1) / (x - 1), x), 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double expected = Math.Round(
                (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 17)
                / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 3), 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -2.0;
            double expected = Math.Round(Math.Pow(3 + 1 / Math.Pow(x, 2), x), 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -28.0;
            double expected = Math.Round(x + 10 * x - (1 / Math.Pow(x, 2)), 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }
    }
}