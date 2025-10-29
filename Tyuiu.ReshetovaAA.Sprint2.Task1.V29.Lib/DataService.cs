using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ReshetovaAA.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            return (x >= 0 && x <= 10 && y >= 0 && y <= 5);
        }
    }
}
