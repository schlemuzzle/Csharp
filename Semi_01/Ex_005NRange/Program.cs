Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
for(int i = -n; i <= n; i++)
{
    Console.Write(i + " ");
}