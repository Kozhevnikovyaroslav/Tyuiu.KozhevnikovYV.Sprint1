// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint1.Task7.V27.Lib;

DataService ds = new DataService();

Console.Title = "Спринт 1 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #1                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #7                                                                   *");
Console.WriteLine("* Вариант #27                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение               *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                        *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("           cosx^2 + siny^2     xy - 12");
Console.WriteLine("    Z =    ---------------  -  -------");
Console.WriteLine("              siny + 1         15 + cosx");

double x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.Calculate(x, y));