using System;
using Tyuiu.ReshetovaAA.Sprint2.Task1.V29.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Решетова Арина | СМАРТб-25-1";

            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                       *");
            Console.WriteLine("* Тема: Операции сравнения и логические выражения                                                 *");
            Console.WriteLine("* Задание #1                                                                                      *");
            Console.WriteLine("* Вариант #29                                                                                     *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)                                 *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^), которая вернет логическую                           *");
            Console.WriteLine("* последовательность (True, True, True, False, True, True) при a=657, b=654, c=657, d=657.        *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

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

