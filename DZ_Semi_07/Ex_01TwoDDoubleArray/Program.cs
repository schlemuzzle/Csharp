using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);
Write("Введите начальный диапазон значений массива: ");
int minValue = int.Parse(ReadLine()!);
Write("Введите конечный диапазон значений массива: ");
int maxValue = int.Parse(ReadLine()!);

double[,] Array = Get2DArray(rows, columns, minValue, maxValue);
PrintArray(Array);

double[,] Get2DArray(int r, int c, int min, int max)
{
    double[,] result = new double[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().NextDouble() * (max - min) + min;
            result[i, j] = Math.Round(result[i, j], 1);
        }
    }
    return result;
}

void PrintArray(double[,] array)
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