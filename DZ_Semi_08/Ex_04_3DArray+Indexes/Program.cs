// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using System;
using static System.Console;

Clear();

Write("Введите размеры массива X x Y x Z через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int sizeX = int.Parse(nums[0]);
int sizeY = int.Parse(nums[1]);
int sizeZ = int.Parse(nums[2]);

Write("Введите диапазон значений элементов массива через пробел: ");
string[] range = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int minV = int.Parse(range[0]);
int maxV = int.Parse(range[1]);

int[,,] Array = GetArray(sizeX, sizeY, sizeZ, minV, maxV);
PrintArray(Array);

int[,,] GetArray(int sizeX, int sizeY, int sizeZ, int minV, int maxV)
{
    int[,,] result = new int[sizeX, sizeY, sizeZ];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minV, maxV + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
           {
                Write($"{array[i, j, k]} [{i},{j},{k}]  ");
           }
            WriteLine();
        }
        WriteLine();
    }
}