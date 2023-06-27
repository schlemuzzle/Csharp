Console.Clear();

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
//int i = 0;

//if (number <= 0)
//{
//    number = number * -1;
//}

//while (number > 0)
//{
//    number = number / 10;
//    i++;
//}
//Console.WriteLine($"Разрядность числа: {i}");

int result = Result(number);
Console.WriteLine($"Разрядность числа: {result}");

int Result(int num)
{
    int index = 0;
    while (num != 0)
    {
        num = num / 10;
        index++;
    }
    return index;
}
