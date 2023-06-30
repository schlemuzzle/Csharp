Console.Clear();

int[] array = GetRandomArray(6, 0, 21);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница минимального и максимального элементов массива: {MaxMinDiff(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int MaxMinDiff(int[] arr)
{
    int max = 0;
    int min = arr[0];
    int diff = 0;
    foreach (int item in arr)
    {
        max = item > max ? item : max;
    }
    foreach (int item in arr)
    {
        min = item < min ? item : min;
    }
    diff = max - min;
    return diff;
}
