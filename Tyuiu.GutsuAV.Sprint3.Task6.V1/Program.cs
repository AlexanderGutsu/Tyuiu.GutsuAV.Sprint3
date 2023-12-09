using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GutsuAV.Sprint3.Task6.V1.Lib;
namespace Tyuiu.GutsuAV.Sprint3.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гуцу А. В. | ИИПб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                               *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* выполнил: Гуцу Александр Владимирович | ИИПб-23-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих      *");
            Console.WriteLine("* числовому отрезку [11, 17] сумму всех делителей.                       *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = 11;
            int stopValue = 17;
            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
