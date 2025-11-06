using System;
using Tyuiu.ReshetovaAA.Sprint2.Task7.V12.Lib;

namespace Tyuiu.SpirinIS.Sprint2.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Решетова А. А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Решетова Арина Алексеевна | СМАРТб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу на C#, которая запрашивает исходные данные и вычисляет*");
            Console.WriteLine("*находится ли точка с координатами X,Y в заштрихованной области.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты точки:");
            Console.Write("X = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
                Console.WriteLine("Точка находится в заштрихованной области.");
            else
                Console.WriteLine("Точка вне заштрихованной области.");

            Console.ReadKey();
        }
    }
}