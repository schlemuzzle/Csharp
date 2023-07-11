// Напишите программу, которая заполнит спирально массив 4 на 4.

using System;
using static System.Console;

Clear();

int[,] Array = GetArray(4, 4);
PrintArray(Array);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns]; 
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= result.GetLength(0) * result.GetLength(1))
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)
        j--;
        else
        i--;
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
