//Задайте двумерный массив.
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
using static System.Console;

Clear();

int[,] Array = GetArray(4, 4, 10, 80);
PrintArray(Array);
WriteLine();
ArrayRowExchange(Array);
PrintArray(Array);

int[,] ArrayRowExchange(int[,] array)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        temp = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = array[0, j];
        array[0, j] = temp;
    }
    return array;
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