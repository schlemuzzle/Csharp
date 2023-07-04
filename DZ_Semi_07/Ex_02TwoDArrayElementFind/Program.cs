using System;
using static System.Console;

Clear();

int[,] Array = GetArray(4, 4, 2, 8);
PrintArray(Array);

Write("Введите индексы искомого элемента массива через пробел: ");
string[] sides = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int row = int.Parse(sides[0]);
int column = int.Parse(sides[1]);

int res = 0;//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

if(row > Array.GetLength(0) || column > Array.GetLength(1))
{
    WriteLine($"Элемента с индексом [{row}, {column}] нет в данном массиве");
}
else
{
    WriteLine($"Элемент с индексом [{row}, {column}] -> {FindArrayElement(Array, row, column)}");
}

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

int FindArrayElement(int[,] array, int indexR, int indexC)
{
    int element = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == indexR && j == indexC)
            {
                element = array[i, j];
            }
        }
    }
    return element;
}
