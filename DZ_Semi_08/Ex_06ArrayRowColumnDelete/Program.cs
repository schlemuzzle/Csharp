﻿//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен первый найденный наименьший элемент.

using System;
using static System.Console;

Clear();

int[,] Array = GetArray(4, 4, 2, 9);
PrintArray(Array);
WriteLine();
PrintArray(GetResultArray(Array, GetIndexMinEl(Array)));


int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[] { 0, 0 };
    int min = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min > inArray[i, j])
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0])
            continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == indexes[1])
                continue;
            result[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
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
