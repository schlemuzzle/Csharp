// Напишите программу,которая будет принимать на вход число и возвращать сумму его цифр.

using System;
using static System.Console;
Clear();

Write("Введите N: ");
int n = int.Parse(ReadLine()!);

WriteLine($"Сумма цифр числа {n} = {SumDigits(n)}");

int SumDigits(int n)
{
    if (n == 0)
        return 0;
    return n % 10 + SumDigits(n / 10);
}
