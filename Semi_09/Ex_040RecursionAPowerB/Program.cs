// Напишите программу,которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

using System;
using static System.Console;
Clear();

Write("Введите A: ");
int a = int.Parse(ReadLine()!);
Write("Введите B: ");
int b = int.Parse(ReadLine()!);

WriteLine($"Число {a} в степени {b} = {APowerB(a, b)}");

int APowerB(int m, int n)
{
    if (n == 0) return 1;
    else return APowerB(m, n - 1) * m;
}