Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) Console.WriteLine("Да, число кратно 7 и 23");
else Console.WriteLine("Нет, число не кратно 7 и 23");
