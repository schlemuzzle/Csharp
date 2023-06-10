Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a%2 == 0)
{
    Console.WriteLine($"Да, {a} - четное");
}
else
{
    Console.WriteLine($"Нет, {a} - не четное");
}