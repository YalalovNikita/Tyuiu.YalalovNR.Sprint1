namespace Tyuiu.YalalovNR.Sprint1.Task3.V1;
using System;
using Tyuiu.YalalovNR.Sprint1.Task3.V1.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = "Спринт #1 | Выполнил: Ялалов Н. Я. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #1                                                             *");
        Console.WriteLine("* Выполнил: Ялалов Никита Ришатович | ИБКСб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#, которая вкоторая запрашивает у поль*");
        Console.WriteLine("*-зователя исходные данные, выполняет указанные расчёты и печатает результат на экране.*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double h,r;
        Console.WriteLine("Напишите значение h: ");
        h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Напишите значение r: ");
        r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Объём цилиндра: " + Math.Round(ds.CylinderVolume(r, h), 2));
    }
}
