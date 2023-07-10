// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using System;
using static System.Console;

Clear();

int[,] Array = GetArray(4, 4, 10, 80);
PrintArray(Array);
WriteLine();
ArrayRowColumnExchange1(Array);
PrintArray(Array);
WriteLine();
PrintArray(ArrayRowColumnExchange2(Array));

void ArrayRowColumnExchange1(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        WriteLine("В данной матрице нельзя заменить элементы!");
        return;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = temp;
        }
    }
}

int[,] ArrayRowColumnExchange2(int[,] array)
{
    int[,] result = new int [array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
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