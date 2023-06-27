Console.Clear();
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(a);

SumDigits(a);
Console.WriteLine($"Сумма цифр числа {a} = {result}");

int SumDigits(int number)
{
    int res = 0;
    while (number>0)
    {
        res = res + number %10;
        number = number/10;
    }
    return res;
}