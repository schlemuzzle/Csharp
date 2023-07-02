Console.Clear();

double[] array = GetRandomArray(6, 2, 4);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница минимального и максимального элементов массива: {MaxMinDiff(array):f2}");

double[] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        result[i] = Math.Round(result[i], 2);
    }
    return result;;
}

double MaxMinDiff(double[] arr)
{
    double max = 0;
    double min = arr[0];
    double diff = 0;
    foreach (double item in arr)
    {
        max = item > max ? item : max;
    }
    foreach ( double item in arr)
    {
        min = item < min ? item : min;
    }
    diff = max - min;
    return diff;
}

