Console.Clear();
Console.WriteLine("Введине первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max={a}");
}
else
{
    Console.WriteLine($"max={b}");
}