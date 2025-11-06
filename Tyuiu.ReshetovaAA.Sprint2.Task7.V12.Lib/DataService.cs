using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ReshetovaAA.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if ((x >= -2 && x <= 1) && (y >= Math.Pow(x, 2)) && (y <= 2 - x))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}