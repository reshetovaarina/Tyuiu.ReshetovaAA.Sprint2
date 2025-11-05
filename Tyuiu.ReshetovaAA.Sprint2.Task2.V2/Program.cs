using Tyuiu.ReshetovaAA.Sprint2.Task2.V2.Lib;
namespace Tyuiu.ReshetovaAA.Sprint2.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Решетова Арина | СМАРТб-25-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #2                                                  *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                    *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Задание #2                                                 *");
            Console.WriteLine("* Тема: условный оператор if                                 *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Вариант #2                                                 *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* запрос целых значений с клавиатуры                         *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("*и вычисление находится ли точка X,Y в заштрихованной области*");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                    *");
            Console.WriteLine("**************************************************************");

            Console.Write("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine(result
                ? $"Точка ({x}, {y}) находится в заштрихованной области."
                : $"Точка ({x}, {y}) НЕ находится в заштрихованной области.");

            Console.ReadKey();
        }
    }
}