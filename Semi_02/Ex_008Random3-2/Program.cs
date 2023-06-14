Console.Clear();
int num = new Random().Next(100, 1000);
int num1 = num / 100; // Или int result = (num / 100) * 10 + num % 10;
int num2 = num % 10;
int result = num1 * 10 + num2;
Console.WriteLine(num);
Console.WriteLine($"Трехзначное число без второй цифры: {result}");
// Или:
Console.WriteLine($"{num} -> {num/100}{num%10}");