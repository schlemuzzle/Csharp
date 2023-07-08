//Собрать строку с числами от a до b, a ≤ b
Console.Clear();

string NumbersFor1(int a, int b)// решение через цикл
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec1(int a, int b)// решение через рекурсию
{
    if (a <= b) return $"{a} " + NumbersRec1(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor1(1, 10));
Console.WriteLine(NumbersRec1(1, 10));

//Собрать строку с числами от a до b, a ≥ b

string NumbersFor2(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec2(int a, int b)
{
    if (a <= b) return NumbersRec2(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersFor2(1, 10));
Console.WriteLine(NumbersRec2(1, 10));