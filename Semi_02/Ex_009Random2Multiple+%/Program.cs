Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int num3 = num1 % num2;
if (num3 == 0) Console.WriteLine("Первое кратно второму");
else Console.WriteLine($"Первое не кратно второму, остаток от деления: {num3}");
// {} ставится если после if/else несколько действий.