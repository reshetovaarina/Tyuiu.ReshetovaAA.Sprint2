using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint2.Task4.V6.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double wait = 0.010; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 20;
            double wait = 411.200; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 10;
            double wait = 0.022;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double wait = 3.667; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}