Console.Clear();

int[] array = GetRandomArray(10, 100, 1000);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Количество четных элементов массива: {EvenAmount(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int EvenAmount(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        count += item % 2 == 0 ? 1 : 0;
    }
    return count;
}
