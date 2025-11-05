using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ReshetovaAA.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Y = 3
            if (y == 3 && (x >= 3 && x <= 5)) return true;

            // Y = 4
            if (y == 4 && x == 4) return true;

            // Y = 5-6
            if ((y == 5 || y == 6) && (x >= 3 && x <= 9)) return true;

            // Y = 7
            if (y == 7 && x == 6) return true;

            // Y = 8
            if (y == 8 && x == 9) return true;

            // Y = 9
            if (y == 9 && (x == 9 || x == 10)) return true;

            // Y = 10
            if (y == 10 && (x >= 9 && x <= 11)) return true;

            // Y = 11-12
            if ((y == 11 || y == 12) && (x >= 3 && x <= 6)) return true;

            // Y = 13
            if (y == 13 && x == 6) return true;

            return false;
        }
    }
}
