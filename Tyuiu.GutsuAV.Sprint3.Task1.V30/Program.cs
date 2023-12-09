using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GutsuAV.Sprint3.Task1.V30.Lib;
namespace Tyuiu.GutsuAV.Sprint3.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3| Выполнил :  Гуцу А. В. | ИИПб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Оператор цикла while                                 *");
            Console.WriteLine("* Задание #1                                                 *");
            Console.WriteLine("* Вариант #30                                                *");
            Console.WriteLine("* Выполнил :  Гуцу Александр Владимирович | ИИПб-23-1        *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет *");
            Console.WriteLine("* произведение ряда по формуле, при x = 0.5                  *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            double value = 0.5;
            int starValue = 1;
            int stopValue = 12;

            Console.WriteLine("Переменная X " + value);
            Console.WriteLine("Старт шага " + starValue);
            Console.WriteLine("Конец шага " + stopValue);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine(" Произведение ряда = " + ds.GetSumSeries(value, starValue, stopValue));

            Console.ReadKey();
        }
    }
}
