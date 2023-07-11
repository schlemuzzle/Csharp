//Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

using System;
using static System.Console;
Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine()!);
Write("Введите N: ");
int n = int.Parse(ReadLine()!);

WriteLine($"Ряд чисел от {m} до {n}: [{PrintNumbers(m, n)}]");

string PrintNumbers(int start, int end)
{
    if (start == end)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}