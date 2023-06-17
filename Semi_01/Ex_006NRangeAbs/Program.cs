Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
int b = (-1) * Math.Abs(n); // Math.Abs - модуль числа
while (b <= Math.Abs(n))
{
    Console.Write($"{b} "); // $ "{b}" позволяет использовать переменную b в строке
    b++;
}