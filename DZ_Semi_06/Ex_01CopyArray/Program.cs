Console.Clear();

Console.WriteLine("Задайте размер и диапазон значений одномерного массива через пробел:");
string[] diap = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int size = int.Parse(diap[0]);
int minValue = int.Parse(diap[1]);
int maxValue = int.Parse(diap[2]);

int[] Array = GetArray(size, minValue, maxValue);
Console.WriteLine($"Заданный массив:[{String.Join(" ", Array)}]");
Console.WriteLine($"Копия заданного массив:[{String.Join(' ', CopyArray(Array))}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] CopyArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}