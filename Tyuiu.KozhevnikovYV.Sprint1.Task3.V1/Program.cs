// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint1.Task3.V1.Lib;

DataService ds = new DataService();

Console.Title = "Спринт 1 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #1                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #3                                                                   *");
Console.WriteLine("* Вариант #1                                                                   *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                  *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

double r, h;

Console.WriteLine("Введите значение R:");
r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение H:");
h = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("Объем цилиндра = " + ds.CylinderVolume(r, h));