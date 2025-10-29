using Tyuiu.ReshetovaAA.Sprint2.Task1.V29.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 5;
            int y = 3;

            bool result = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, result);
        }
    }
}
