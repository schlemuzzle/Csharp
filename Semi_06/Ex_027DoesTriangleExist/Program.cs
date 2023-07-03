Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");

string[] sides = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(sides[0]);
int b = int.Parse(sides[1]);
int c = int.Parse(sides[2]);

if (IsTriangle(a, b, c))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool IsTriangle(int a, int b, int c)
{
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}


