﻿// See https://aka.ms/new-console-template for more information

using Tyuiu.KozhevnikovYV.Sprint1.Task1.V16.Lib;

DataService ds = new DataService();

Console.Title = "Спринт 1 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #1                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #1                                                                   *");
Console.WriteLine("* Вариант #16                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
Console.WriteLine("* вычисляет результат по формуле x*5*a+2*y и печатает его на экране.           *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

double x, y, a;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение A:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.Calculate(a,x,y));