namespace Tyuiu.YalalovNR.Sprint1.Task2.V18;
using System;
using Tyuiu.YalalovNR.Sprint1.Task2.V18.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = "Спринт #1 | Выполнил: Ялалов Н. Я. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Ялалов Никита Ришатович | ИБКСб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#, которая вычисляет Площадь боковой  *");
        Console.WriteLine("* поверхности параллелепипеда                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int a, b,c;
        Console.WriteLine("Напишите значение A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Напишите значение B: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Напишите значение C: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Площадь боковой поверхности параллелепипеда:" + ds.CalculateSideSquareParallelepiped(a,b,c));
    }
}
