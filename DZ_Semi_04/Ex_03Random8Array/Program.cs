Console.Clear();
Console.WriteLine("Введите длинну массива ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальный диапазон массива ");
int MinArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечный диапазон массива ");
int MaxArr = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[Length];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(MinArr, MaxArr + 1);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

FillArray(Array);
PrintArray(Array);
