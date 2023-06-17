Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
if (a > b && a > c)
{
    Console.WriteLine($"max={a}");
}
else if (a < b && b > c)
{
    Console.WriteLine($"max={b}");
}
else
{
    Console.WriteLine($"max={c}");
}