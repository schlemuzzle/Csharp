﻿Console.Clear();
Console.Write("Введите номер дня недели (от 1 до 7): ");
int numDay = int.Parse(Console.ReadLine()!); 
Console.Write("Выбранный день: ");
if(numDay == 1) Console.Write("Понедельник");
else if (numDay == 2) Console.Write("Вторник");
else if (numDay == 3) Console.Write("Среда");
else if (numDay == 4) Console.Write("Четверг");
else if (numDay == 5) Console.Write("Пятница");
else if (numDay == 6) Console.Write("Суббота");
else if (numDay == 7) Console.Write("Воскресение");
else Console.Write("нет такого дня недели");