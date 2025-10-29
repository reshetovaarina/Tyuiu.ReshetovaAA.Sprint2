using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ReshetovaAA.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == c) | (b < d);
            res[1] = (a != b) & (c >= d);
            res[2] = (a > b) || (c == d);
            res[3] = (a < b) && (c > d);
            res[4] = (a <= d) ^ (b > c);
            res[5] = (a == d) && (c >= b);

            return res;
        }
    }
}
