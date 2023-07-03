Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine()!;
int[] Array = GetArrayFromString(elements);
Console.WriteLine($"Количество положительных чисел: {AmountOf0(Array)}");

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int AmountOf0(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result = result + 1;
    }
    return result;
}