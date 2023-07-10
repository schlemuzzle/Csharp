// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

using System;
using static System.Console;

Clear();

int[,] Array = GetArray(3, 3, 1, 5);
PrintArray(Array);
WriteLine();
int[] RowArray = GetRowArray(Array);
SortArray(RowArray);
WriteLine(String.Join(" ", RowArray));
PrintData(RowArray);


int[] GetRowArray(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[index] = array[i, j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int k = array[i];
                array[i] = array[j];
                array[j] = k;
            }
        }
    }
}

void PrintData(int[] array)
{
    int el = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != el)
        {
            WriteLine($"{el} встречается {count} раз");
            el = array[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count} раз");
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
