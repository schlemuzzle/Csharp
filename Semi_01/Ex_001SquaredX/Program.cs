Console.Clear();
int num = int.Parse(Console.ReadLine()!); // Преобразует данные с консоли из 'string' в 'int'
// Первый способ - математический:
int num2 = num * num;
Console.WriteLine($"Первый способ num^2 -> {num2}");
// Второй способ - при помощи библиотеки:
int num3 = Convert.ToInt32(Math.Pow(num, 2)); // 32 - размер ячейки памяти для числа (можно и 16) 
// Math - наименование бибилиотеки, Pow - функция возведения в степень (на выходе будет 'double', поэтому конвертируем в 'int')
Console.WriteLine($"Второй способ num^2 -> {num3}");