Console.Clear();
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Degree(a, b);

if (b <= 0)
{
    Console.WriteLine($"Степень не может быть меньше 0");
    return;
}

Degree(a, b);
Console.WriteLine($"Число {a} в степени {b} = {result}");

int Degree(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        checked
        {
            res *= a;
        }
    }
    return res;
}