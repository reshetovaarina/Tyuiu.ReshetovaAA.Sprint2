using System;
using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint2;

[assembly: InternalsVisibleTo("Tyuiu.ReshetovaAA.Sprint2.Task6.V11.Test")]
namespace Tyuiu.ReshetovaAA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (g < 1 || m < 1 || m > 12|| n < 1 || n > 31)
            {
                return "Ошибка: неверная дата";
            }

            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            int daysInMonth = m switch
            {
                1 => 31, 
                2 => 28,  
                3 => 31,  
                4 => 30,  
                5 => 31,  
                6 => 30,  
                7 => 31,  
                8 => 31,  
                9 => 30, 
                10 => 31, 
                11 => 30, 
                12 => 31,
                _ => 0
            };

            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth++;

                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            return $"{nextDay}.{nextMonth}.{nextYear}";
        }
    }
}