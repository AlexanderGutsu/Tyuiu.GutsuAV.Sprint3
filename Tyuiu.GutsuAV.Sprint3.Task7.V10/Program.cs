﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GutsuAV.Sprint3.Task7.V10.Lib;
namespace Tyuiu.GutsuAV.Sprint3.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гуцу А.В. | ИИПб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 3                                                                  *");
            Console.WriteLine("*Тема: Добавление к решению итоговых проектов по спринту                   *");
            Console.WriteLine("*Задание #7                                                                *");
            Console.WriteLine("*Вариант #10                                                               *");
            Console.WriteLine("*Выполнил: Гуцу Александр Владимирович| ИИПб-23-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции             *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("+    X     +   f(x)   +");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |{1,8:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadLine();
        }
    }
}
