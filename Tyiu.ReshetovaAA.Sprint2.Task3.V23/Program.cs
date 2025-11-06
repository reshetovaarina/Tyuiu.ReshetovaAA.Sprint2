using System;
using Tyuiu.ReshetovaAA.Sprint2.Task3.V23.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Задание #3 | Вариант 23 | Решетова Арина";

            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                   *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                                         *");
            Console.WriteLine("* Задание #3                                                                                  *");
            Console.WriteLine("* Вариант #23                                                                                 *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                                     *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет значение функции Y                                   *");
            Console.WriteLine("* в зависимости от введённого значения X с клавиатуры.                                        *");
            Console.WriteLine("* Округлить результат до трёх знаков после запятой.                                           *");
            Console.WriteLine("*                                                                                             *");
            Console.WriteLine("* Если x > 1:     y = x * ((x + 1) / (x - 1)) ^ x                                             *");
            Console.WriteLine("* Если x = 0:     y = (x^2 + cos(x^2) - 17) / (x^2 - sin(x^2) + 3)                            *");
            Console.WriteLine("* Если -27 < x < 2: y = (3 + 1/x^2) ^ x                                                       *");
            Console.WriteLine("* Если x < -27:   y = x + 10x - (1/x^2)                                                       *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine();

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = ds.Calculate(x);

            Console.WriteLine();
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine($"РЕЗУЛЬТАТ: Y = {y}");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* Программа завершена. Нажмите любую клавишу для выхода.                                      *");
            Console.WriteLine("***********************************************************************************************");

            Console.ReadKey();
        }
    }
}
