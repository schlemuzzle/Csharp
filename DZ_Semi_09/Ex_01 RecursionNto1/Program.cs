//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;
using static System.Console;

Clear();

Write("Введите N: ");
int n = int.Parse(ReadLine()!);

WriteLine($"Ряд чисел от {n} до 1: [{PrintNumbers(n)}]");

string PrintNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    string s = n.ToString() + ", " +  PrintNumbers(n - 1);
    return s;
}