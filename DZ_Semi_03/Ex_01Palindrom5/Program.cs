Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int p = int.Parse(Console.ReadLine()!);
int a = p / 10000;
int b = p % 10;
int c = (p % 10000 - p % 1000) / 1000;
int d = (p % 100 - b) / 10;

if (a == b && c == d) Console.WriteLine("Да, введенное число - палиндром.");
else Console.WriteLine("Нет, введенное число - не палиндром.");