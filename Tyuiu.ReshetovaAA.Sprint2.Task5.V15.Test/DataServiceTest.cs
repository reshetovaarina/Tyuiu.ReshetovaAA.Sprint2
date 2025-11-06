using Tyuiu.ReshetovaAA.Sprint2.Task5.V15.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName1()
        {
            DataService ds = new DataService();
            int k = 1;
            string wait = "Понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDayName2()
        {
            DataService ds = new DataService();
            int k = 7;
            string wait = "Воскресенье";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDayName3()
        {
            DataService ds = new DataService();
            int k = 15;
            string wait = "Понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDayName4()
        {
            DataService ds = new DataService();
            int k = 32;
            string wait = "Четверг";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDayName5()
        {
            DataService ds = new DataService();
            int k = 365;
            string wait = "Понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDayNameEdgeMin()
        {
            DataService ds = new DataService();
            int k = 1;
            string wait = "Понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDayNameEdgeMax()
        {
            DataService ds = new DataService();
            int k = 365;
            string wait = "Понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }
    }
}