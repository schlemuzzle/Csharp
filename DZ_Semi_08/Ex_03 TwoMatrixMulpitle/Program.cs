// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;
using static System.Console;

Clear();

int[,] Array1 = GetArray(4, 3, 2, 5);
PrintArray(Array1);
WriteLine();
int[,] Array2 = GetArray(3, 4, 2, 5);
PrintArray(Array2);
WriteLine();

if (Array1.GetLength(0) == Array2.GetLength(1))
    {
        PrintArray(GetMultiplicatedMatrix(Array1, Array2));
    }
else WriteLine("Матрицы несовместимы.");

int[,] GetMultiplicatedMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array3[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
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
