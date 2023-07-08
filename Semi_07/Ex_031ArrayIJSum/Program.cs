using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] Array = GetArray(rows, columns);
PrintArray(Array);

int[,] GetArray(int r, int c)
{
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = i + j;
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
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}