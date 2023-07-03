Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void ReverseArray1(int[] Array)
{
    for (int i = 0; i < Array.Length / 2; i++)
    {
        int temp = Array[i];
        Array[i] = Array[Array.Length - 1 - i];
        Array[Array.Length - 1 - i] = temp;
    }
}

int[] ReverseArray2(int[] Array)
{
    int[] result = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        int temp = Array[i];
        Array[i] = Array[Array.Length - 1 - i];
        Array[Array.Length - 1 - i] = temp;
    }
    return Array;
}


int[] array = GetRandomArray(6, -6, 6);
Console.WriteLine(String.Join(", ", array));
ReverseArray1(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(String.Join(", ", ReverseArray2(array)));