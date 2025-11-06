using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.ReshetovaAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay1()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 1;
            int n = 15;
            string wait = "16.01.2023";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay2()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 1;
            int n = 31;
            string wait = "01.02.2023";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay3()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 2;
            int n = 28;
            string wait = "01.03.2023";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay4()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 12;
            int n = 31;
            string wait = "01.01.2024";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay5()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 4;
            int n = 30;
            string wait = "01.05.2023";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDay6()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 9;
            int n = 8;
            string wait = "09.09.2023";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
