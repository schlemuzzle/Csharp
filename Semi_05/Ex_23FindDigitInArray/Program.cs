﻿Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine()!;
int[] baseArray = GetArrayFromString(elements);
Console.Write("Введите искомое число: ");
int n = int.Parse(Console.ReadLine()!);
if (FindElement(baseArray, n)) 
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");// split - разделяет элементы по вводу пробела в строке
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int el)
{
    foreach (int item in array)
    {
        if (el == item) return true;
    }
    return false;
}