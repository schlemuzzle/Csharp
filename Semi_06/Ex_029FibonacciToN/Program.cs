Console.Clear();
Console.Write("Введите количество чисел ряда Фибоначчи, которые нужно отобразить: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Требуемое количество чисел ряда: [{String.Join(' ', FibonacciToN(n))}]");

int[] FibonacciToN(int num)
{
    int[] res = new int[num];
    res[0] = 0;
    if (num >= 2) 
    {
        res[1] = 1;
    }
    else 
    {
        return res;
    }
    for (int i = 2; i < num; i++)
    {
        res[i] = res[i - 2] + res[i - 1];
    }
    return res;
}