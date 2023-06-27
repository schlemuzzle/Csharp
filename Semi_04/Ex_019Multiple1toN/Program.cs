Console.Clear();

Console.WriteLine("Введите целое положительное число ");
int num = Convert.ToInt32(Console.ReadLine());

int mult = Mult(num);
Console.WriteLine($"Произведение от 1 до {num} = {mult}");

int Mult(int n)
{
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
        checked
        {
            res = n * i;
        }
    }
    return res;
}