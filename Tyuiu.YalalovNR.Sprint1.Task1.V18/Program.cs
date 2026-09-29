namespace Tyuiu.YalalovNR.Sprint1.Task0.V27;
using System;
using Tyuiu.YalalovNR.Sprint1.Task1.V18.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = "Спринт #1 | Выполнил: Ялалов Н. Я. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Ялалов Никита Ришатович | ИБКСб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#, которая вычисляет выражение        *");
        Console.WriteLine("* (x*y)/(x+1)-3                                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   (x*y)/(x+1)-3                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double x, y;
        Console.WriteLine("Напишите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Напишите значение Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(ds.Calculate(x, y));
    }
}
