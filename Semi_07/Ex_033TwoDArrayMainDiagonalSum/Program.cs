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

int[,] Array = GetArray(rows, columns, minValue, maxValue);
PrintArray(Array);
WriteLine();
WriteLine($" Сумма элементов главной диагонали массива: {MainDiagonalArraySum(Array)}");
WriteLine();
WriteLine($" Сумма элементов главной диагонали массива: {GetSumDiag(Array)}");

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

int MainDiagonalArraySum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result += array[i, j];
            }
        }
    }
    return result;
}

int GetSumDiag(int[,] array) // решение преподавателя
{
    int length = array.GetLength(0) < array.GetLength(1) ?
    array.GetLength(0) : array.GetLength(1);
    // if (array.GetLength(0) < array.GetLength(1))
    //      length = array.GetLength(0);
    // else
    //      length = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
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