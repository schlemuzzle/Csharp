using System;
using static System.Console;

Clear();

int[,] Array = GetArray(3, 4, 2, 6);
PrintArray(Array);
double[] average = ArrayColumnsAverage(Array);

WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ",average)}");

int[,] GetArray(int r, int c, int min, int max)
{
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
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

double[] ArrayColumnsAverage(int[,] array)
{
    double[] element = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        element[i] = sum / array.GetLength(0);
        element[i] = Math.Round(element[i], 1);
    }
    return element;
}
