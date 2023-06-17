Console.Clear();
Console.Write("Введите номер дня недели (от 1 до 7): ");
int numDay = int.Parse(Console.ReadLine()!); 
if(numDay >= 1 && numDay<=5) Console.Write("Паши дальше!");
else if (numDay == 6 || numDay == 7) Console.Write("Да, выходной.");
else Console.Write("Нет такого дня недели.");