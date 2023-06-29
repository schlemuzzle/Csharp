Console.Clear();

int[] Array = new int[12];

FillArray(Array);
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine($"Количество эл-тов [10;100]: {Amount2Digits(Array, 9, 100)}");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 500);
    }
}

int Amount2Digits(int[] arr, int min, int max)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item > min && item < max)
        {
            count++;
        }
    }
    return count;
}
