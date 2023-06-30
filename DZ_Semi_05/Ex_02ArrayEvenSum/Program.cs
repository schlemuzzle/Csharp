Console.Clear();

int[] array = GetRandomArray(6, -20, 21);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма элементов четных позиций массива: {EvenSum(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int EvenSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
