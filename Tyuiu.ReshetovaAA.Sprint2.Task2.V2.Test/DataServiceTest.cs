using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint2.Task2.V2.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(5, 5);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(1, 1);
            Assert.AreEqual(false, result);
        }
    }
}
