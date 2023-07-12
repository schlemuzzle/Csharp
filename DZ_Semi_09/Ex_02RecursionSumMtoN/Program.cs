//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;

Clear();

Write("Введите M: ");
int m = int.Parse(ReadLine()!);
Write("Введите N: ");
int n = int.Parse(ReadLine()!);

WriteLine($"Сумма цифр в промежутке от {m} до {n} = {SumDigits(m, n)}");

int SumDigits(int m, int n)
{
    if (m == n)
        return m;
    return m + SumDigits(m + 1, n);
}