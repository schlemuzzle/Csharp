Console.Clear();

int[] RandArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int[] InvertSigh(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int[] array = RandArray(6, -4, 4);
Console.WriteLine(String.Join(", ", array));
int[] invArray = InvertSigh(array);
Console.WriteLine(String.Join(", ", invArray));