Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int result = (num % 100 - num % 10) / 10;
Console.WriteLine($"Вторая цифра введеного числа: {result}");