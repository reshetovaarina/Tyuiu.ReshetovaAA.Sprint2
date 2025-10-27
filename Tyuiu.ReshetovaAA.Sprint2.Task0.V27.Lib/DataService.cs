using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ReshetovaAA.Sprint2.Task0.V27.Lib
{
    public class DataService : ISprint2Task0V27
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x > y;
            res[1] = x == y;
            res[2] = x != y;
            res[3] = x < (y - 1000);
            res[4] = (x + y) <= 1000;
            res[5] = (x / 5) >= (y / 10);

            return res;
        }
    }
}
