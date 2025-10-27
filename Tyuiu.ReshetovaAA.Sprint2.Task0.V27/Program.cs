using System;
using Tyuiu.ReshetovaAA.Sprint2.Task0.V27.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task0.V27.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Решетова Арина | СМАРТб-25-1";

            int x = 1305;
            int y = 275;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                       *");
            Console.WriteLine("* Тема: Операции сравнения и логические выражения                                                 *");
            Console.WriteLine("* Задание #0                                                                                      *");
            Console.WriteLine("* Вариант #27                                                                                     *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)                                 *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность                        *");
            Console.WriteLine("* (True, False, True, False, False, True) при x = 1305, y = 275.                                  *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
