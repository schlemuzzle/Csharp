Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!); 
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!); 
if(num1 == num2 * num2)
{
    Console.WriteLine("Да, первое является квадратом второго");
}
else
{
    Console.WriteLine("Нет, первое не является квадратом второго");
}
