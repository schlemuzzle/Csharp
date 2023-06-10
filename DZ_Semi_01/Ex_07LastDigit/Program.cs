Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if (a < 99 || a > 999)
{
    Console.WriteLine("Введено не трехзначное число");
    return; 
}
int b = a % 10;
Console.WriteLine($"Последняя цифра: {b}");