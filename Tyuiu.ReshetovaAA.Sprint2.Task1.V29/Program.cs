using Tyuiu.ReshetovaAA.Sprint2.Task1.V29.Lib;

namespace Tyuiu.ReshetovaAA.Sprint2.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Решетова Арина | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                       *");
            Console.WriteLine("* Тема: Проверка принадлежности точки области                                                     *");
            Console.WriteLine("* Задание #1                                                                                      *");
            Console.WriteLine("* Вариант #29                                                                                     *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу, которая проверяет принадлежность точки (x, y)                               *");
            Console.WriteLine("* заштрихованной области.                                                                         *");
            Console.WriteLine("* Вернуть True, если точка принадлежит области, иначе False.                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                                                    *");
            Console.WriteLine("***************************************************************************************************");

            Console.Write("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("Точка принадлежит заштрихованной области: " + result);

            Console.ReadKey();
        }
    }

}