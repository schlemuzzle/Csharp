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
    for (int i = 0; i < array.GetLength(0); i++) // GetLenght(0) - кол-во строк
    {
        for (int j = 0; j < array.GetLength(1); j++) // GetLenght(0) - кол-во столбцов
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}