namespace Tyuiu.YalalovNR.Sprint1.Task4.V15;
using System;
using Tyuiu.YalalovNR.Sprint1.Task4.V15.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = "Спринт #1 | Выполнил: Ялалов Н. Я. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Ялалов Никита Ришатович | ИБКСб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#,  вычисляет результат по формуле    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: (x+y^2)/e^2-4*y                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double x, y;
        Console.WriteLine("Напишите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Напишите значение Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ответ: " + Math.Round(ds.Calculate(x, y),3));
    }
}
